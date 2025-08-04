using CarRepairShop.AppSettings;
using CarRepairShop.CRM.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.CRM.Presenter
{
    public class CRMFormPresenter
    {
        private GenericRepository _genericRepo;
        private ICRMForm _view;
        private int? _taskID;
        private List<Domain.Entities.Contractors> _contractors;
        private List<ContractorsCars> _contractorsCars;
        private List<Domain.Entities.Services> _services;
        private List<Model.RequiredServicesModel> _currentSelectedServices = new List<Model.RequiredServicesModel>();
        private bool _closeConfirmed;

        public CRMFormPresenter(ICRMForm view, int? taskID)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _taskID = taskID;

            _contractors = _genericRepo.GetAll<Domain.Entities.Contractors>().ToList();

            if (!_contractors.Any(_contractors => _contractors.ID == 0))
            {
                _contractors.Add(new Domain.Entities.Contractors
                {
                    ID = 0,
                    Surname = string.Empty
                });
            }

            _contractorsCars = _genericRepo.GetAll<ContractorsCars>().ToList();
            _services = _genericRepo.GetAll<Domain.Entities.Services>($"WHERE {nameof(Domain.Entities.Services.IsActive)} = 1").ToList();
            _closeConfirmed = false;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadForm;
            _view.ComboboxSelectionChanged -= ContractorSelectionChanged;
            _view.RequiredServicesDataGridViewCellClick += SelectRequiredServices;
            _view.IncreaseQuantityButtonClicked += IncreaseQuantity;
            _view.DecreaseQuantityButtonClicked += DecreaseQuantity;
            _view.ConfirmButtonClicked += ConfirmAction;
            _view.CancelButtonClicked += CancelAction;
            _view.FormIsClosed += FormIsClosed;
        }

        private void ContractorSelectionChanged(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID == 0)
                _view.LoadContractorVehicles(new List<ContractorsCars>());

            _view.LoadContractorVehicles(_contractorsCars
                .Where(x => x.ContractorID == _view.SelectedContractorID)
                .OrderBy(x => x.ID)
                .ToList());
        }

        private void LoadForm(object sender, EventArgs e)
        {
            var contractors = _contractors
                .Select(x => new Model.ContractorModel
                {
                    ID = x.ID,
                    FullName = $"{x.Name} {x.Surname}",
                })
                .OrderBy(x => x.FullName)
                .ToList();

            _view.LoadContractors(contractors);
            _view.LoadRequiredServices(_services.OrderBy(x => x.ID).ToList());

            LoadTaskData();

            _view.ComboboxSelectionChanged += ContractorSelectionChanged;
        }

        private void LoadTaskData()
        {
            if (_taskID == null || _taskID < 0)
            {
                _view.CreationDate = DateTime.Now;
                _view.MechanicName = CurrentUser.Data.Name;
                _view.MechanicSurname = CurrentUser.Data.Surname;
                _view.TaskClosed = false;
                _view.ChangeTaskClosedAccesability(false);
                return;
            }

            var task = _genericRepo.GetAll<CRM_Task>($"WHERE {nameof(CRM_Task.TaskID)} = {_taskID}").FirstOrDefault();
            if (task != null)
            {
                var mechanicData = _genericRepo.GetAll<Domain.Entities.Users>($"WHERE {nameof(Domain.Entities.Users.ID)} = {task.MechanicID}").FirstOrDefault();
                var selectedServices = _genericRepo.GetAll<CRM_Services>($"WHERE {nameof(CRM_Services.TaskID)} = {task.TaskID}").ToList();

                _view.ChangeTaskClosedAccesability(true);
                _view.CreationDate = task.StartDate;
                _view.MechanicName = mechanicData.Name;
                _view.MechanicSurname = mechanicData.Surname;
                _view.TaskComment = task.Comment;
                _view.SelectedContractorID = task.ContractorID;
                _view.LoadContractorVehicles(_contractorsCars.Where(x => x.ContractorID == task.ContractorID).OrderBy(x => x.ID).ToList());
                _view.SelectedVehicleID = task.CarID;
                _view.LoadRequiredServices(_services.OrderBy(x => x.ID).ToList());
                _view.TaskClosed = task.Completed;
                _view.ChangeTaskStatus(task.Completed);
                _view.SelectedRequiredServiceID = selectedServices.Select(x => x.ServiceID).ToList();
                _currentSelectedServices = _services
                    .Join(
                        selectedServices,
                        service => service.ID,
                        selected => selected.ServiceID,
                        (service, mappings) => new Model.RequiredServicesModel
                        {
                            ID = service.ID,
                            Name = service.Name,
                            Price = service.StandardCost,
                            Quantity = mappings.Quantity
                        })
                    .ToList();

                if (_view.TaskClosed)
                    _view.ChangeTaskClosedAccesability(false);
                if (task.EndDate != null)
                    _view.CloseDate = task.EndDate.Value;

                _view.LoadSelectedServices(_currentSelectedServices);
                _view.SelectAllSelectedServices();
                UpdatePrice();
                _view.TaskClosedCheckBoxCheckedChanged += ChangeTaskStatus;
            }
        }

        private void SelectRequiredServices(object sender, EventArgs e)
        {
            var selectedServiceIDs = _view.SelectedRequiredServiceID;

            if (selectedServiceIDs == null || !selectedServiceIDs.Any())
            {
                _currentSelectedServices.Clear();
                _view.LoadSelectedServices(new List<Model.RequiredServicesModel>());
                return;
            }

            _currentSelectedServices = _services
                .Where(x => selectedServiceIDs.Contains(x.ID))
                .Select(x =>
                {
                    var existing = _currentSelectedServices.FirstOrDefault(s => s.ID == x.ID);
                    var quantity = (existing != null && existing.Quantity > 0) ? existing.Quantity : 1;

                    return new Model.RequiredServicesModel
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Price = x.StandardCost,
                        Quantity = quantity
                    };
                })
                .ToList();


            _view.LoadSelectedServices(_currentSelectedServices);
            UpdatePrice();
        }


        private void DecreaseQuantity(object sender, EventArgs e)
        {
            if (_view.SelectedServiceID <= 0) return;

            var service = _currentSelectedServices.FirstOrDefault(s => s.ID == _view.SelectedServiceID);

            if (service != null)
            {
                service.Quantity--;

                if (service.Quantity < 1)
                    _currentSelectedServices.Remove(service);

                _view.LoadSelectedServices(_currentSelectedServices);
            }

            UpdatePrice();
        }


        private void IncreaseQuantity(object sender, EventArgs e)
        {
            if (_view.SelectedServiceID <= 0) return;

            var service = _currentSelectedServices.FirstOrDefault(s => s.ID == _view.SelectedServiceID);
            if (service != null)
            {
                service.Quantity++;
                _view.LoadSelectedServices(_currentSelectedServices);
            }

            UpdatePrice();
        }

        private void UpdatePrice()
        {
            if (_currentSelectedServices == null || !_currentSelectedServices.Any())
            {
                _view.TotalPrice = 0; return;
            }

            var totalPrice = Convert.ToDecimal(_currentSelectedServices.Sum(s => s.Price * s.Quantity));
            _view.TotalPrice = totalPrice;
        }

        private void ChangeTaskStatus(object sender, EventArgs e)
        {
            _view.TaskClosedCheckBoxCheckedChanged -= ChangeTaskStatus;

            if (_view.TaskClosed)
            {
                if (!_view.ConfirmAction("Are you sure you want to close this task?", "Confirmation"))
                {

                    _view.TaskClosed = false;
                    _view.ChangeTaskStatus(_view.TaskClosed);
                    _view.TaskClosedCheckBoxCheckedChanged += ChangeTaskStatus;
                    return;
                }
            }
            else
            {
                if (!_view.ConfirmAction("Are you sure you want to reopen this task?", "Confirmation"))
                {
                    _view.TaskClosed = true;
                    _view.ChangeTaskStatus(_view.TaskClosed);
                    _view.TaskClosedCheckBoxCheckedChanged += ChangeTaskStatus;
                    return;
                }
            }

            _view.TaskClosedCheckBoxCheckedChanged += ChangeTaskStatus;
            _view.ChangeTaskStatus(_view.TaskClosed);
        }

        private void CancelAction(object sender, EventArgs e)
        {
            _view.OperationConfirmed = DialogResult.No;
            _view.CloseForm();
        }

        private void ConfirmAction(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID <= 0)
            {
                _view.ShowMessage("Please select a contractor.", "Error"); return;
            }

            if (_view.SelectedVehicleID <= 0)
            {
                _view.ShowMessage("Please select a vehicle.", "Error"); return;
            }

            if (_currentSelectedServices == null || !_currentSelectedServices.Any())
            {
                _view.ShowMessage("Please select at least one service.", "Error"); return;
            }

            if (string.IsNullOrEmpty(_view.TaskComment.Trim()))
            {
                if (!_view.ConfirmAction("Do you want to leave the comment empty?", "Warning")) return;
            }

            _view.OperationConfirmed = DialogResult.Yes;
            _closeConfirmed = true;
            _view.CloseForm();
        }

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            if (!_closeConfirmed) _view.OperationConfirmed = DialogResult.No;
        }
    }
}
