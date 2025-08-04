using CarRepairShop.AppSettings;
using CarRepairShop.CRM.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.CRM;
using CarRepairShop.MainForm.Views.Tabs.CRM;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Presenters.Tabs.CRM
{
    public class CRMTabPresenter
    {
        private ICRMTab _view;
        private IGenericRepository _genericRepo;
        private ICurrentUserService _currentUserService;

        private List<CRM_Task> _crms;
        private List<CRM_Services> _crmServices;
        private List<Domain.Entities.Services> _services;
        private List<ContractorsCars> _contractorsCars;
        private List<Domain.Entities.Contractors> _contractors;
        private List<Domain.Entities.Users> _mechanics;

        private List<CRM_Model> _models;

        public CRMTabPresenter(ICRMTab view, IGenericRepository genericRepo, ICurrentUserService userService)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUserService = userService;

            _crms = _genericRepo.GetAll<CRM_Task>().ToList();
            _crmServices = _genericRepo.GetAll<CRM_Services>().ToList();
            _contractors = _genericRepo.GetAll<Domain.Entities.Contractors>().ToList();
            _contractorsCars = _genericRepo.GetAll<ContractorsCars>().ToList();
            _mechanics = _genericRepo.GetAll<Domain.Entities.Users>().ToList();
            _services = _genericRepo.GetAll<Domain.Entities.Services>().ToList();

            _models = _crms.Select(crm => new CRM_Model
            {
                ID = crm.TaskID,
                Description = crm.Comment,
                StartDate = crm.StartDate.ToString("dd//MM/yyyy HH:mm"),
                Completed = crm.Completed,
                EndDate = crm.EndDate?.ToString("dd//MM/yyyy HH:mm") ?? string.Empty,
                TaskCreatorFullname = $"{_mechanics.FirstOrDefault(c => c.ID == crm.MechanicID).Name} {_mechanics.FirstOrDefault(c => c.ID == crm.MechanicID).Surname}",
                CustomerFullname = $"{_contractors.FirstOrDefault(c => c.ID == crm.ContractorID).Name} {_contractors.FirstOrDefault(c => c.ID == crm.ContractorID).Surname}",
                Price = (decimal)crm.Price,
                VehicleDetails = $"{_contractorsCars.FirstOrDefault(c => c.ID == crm.CarID).BrandName} {_contractorsCars.FirstOrDefault(c => c.ID == crm.CarID).ModelName} {_contractorsCars.FirstOrDefault(c => c.ID == crm.CarID).Year}",
                Services = string.Join(", ",
                    _crmServices
                        .Where(
                            cs => cs.TaskID == crm.TaskID)
                        .Select(cs =>
                            {
                                var service = _services.FirstOrDefault(s => s.ID == cs.ServiceID);
                                return service != null ? $"{service.Name} x {cs.Quantity}" : null;
                            })
                        .Where(s => s != null))
            }).ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.AddButtonClicked += OnAddButtonClicked;
            _view.EditButtonClicked += OnEditButtonClicked;
            _view.DeleteButtonClicked += OnDeleteButtonClicked;
            _view.FormIsLoaded += LoadData;
            _view.DebounceElapsed += FilterData;
            _view.FilterChanged += StartDebounce;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.FilterDateFrom = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            _view.StopDebounce();
            _view.PopulateCRMTasksGrid(GetFilteredModels());
            _view.ChangeButtonAccess(
                _currentUserService.IsAdmin
                || _currentUserService.HasPermission(Utilities.Permissions.PermissionTabs.CRM, Utilities.Permissions.Permissions.AllowEdit));
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            if (!_currentUserService.IsAdmin
                || !_currentUserService.HasPermission(Utilities.Permissions.PermissionTabs.CRM, Utilities.Permissions.Permissions.AllowEdit)) return;

            var form = new CRMForm(null);
            form.ShowDialog();

            if (form.OperationConfirmed != DialogResult.Yes) return;

            var crm = new CRM_Task
            {
                ContractorID = form.SelectedContractorID,
                CarID = form.SelectedVehicleID,
                StartDate = form.CreationDate,
                Completed = false,
                MechanicID = _currentUserService.Data.ID,
                Comment = form.TaskComment,
                Price = Convert.ToDouble(form.TotalPrice)
            };

            _genericRepo.Insert(crm);

            var crmServiceMappings = form.SelectedRequiredServiceID
                .Select(
                    serviceId => new CRM_Services
                    {
                        TaskID = crm.TaskID,
                        ServiceID = serviceId,
                        Quantity = form.SelectedServiceQuantities != null && form.SelectedServiceQuantities.ContainsKey(serviceId)
                            ? form.SelectedServiceQuantities[serviceId]
                            : 1
                    })
                .ToList();

            _genericRepo.Insert(crmServiceMappings);

            _crms.Add(crm);
            _crmServices.AddRange(crmServiceMappings);
            _models.Add(new CRM_Model
            {
                ID = crm.TaskID,
                Description = crm.Comment,
                StartDate = crm.StartDate.ToString("dd//MM/yyyy HH:mm"),
                Completed = crm.Completed,
                EndDate = null,
                TaskCreatorFullname = $"{_mechanics.FirstOrDefault(c => c.ID == crm.MechanicID).Name} {_contractors.FirstOrDefault(c => c.ID == crm.MechanicID).Surname}",
                CustomerFullname = $"{_contractors.FirstOrDefault(c => c.ID == crm.ContractorID).Name} {_contractors.FirstOrDefault(c => c.ID == crm.ContractorID).Surname}",
                Price = (decimal)crm.Price,
                VehicleDetails = $"{_contractorsCars.FirstOrDefault(c => c.ID == crm.CarID).BrandName} {_contractorsCars.FirstOrDefault(c => c.ID == crm.CarID).ModelName} {_contractorsCars.FirstOrDefault(c => c.ID == crm.CarID).Year}",
                Services = string.Join(", ",
                    _crmServices
                        .Where(
                            cs => cs.TaskID == crm.TaskID)
                        .Select(cs =>
                            {
                                var service = _services.FirstOrDefault(s => s.ID == cs.ServiceID);
                                return service != null ? $"{service.Name} x {cs.Quantity}" : null;
                            })
                        .Where(s => s != null))
            });

            _view.PopulateCRMTasksGrid(GetFilteredModels());
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            if (!_currentUserService.IsAdmin
                || !_currentUserService.HasPermission(Utilities.Permissions.PermissionTabs.CRM, Utilities.Permissions.Permissions.AllowEdit)) return;

            var id = _view.SelectedCRMTaskID;
            var taskBeforeUpdate = _crms.Where(x => x.TaskID == id).FirstOrDefault();
            var taskMappingsBeforeUpdate = _crmServices.Where(x => x.TaskID == id).ToList();

            var form = new CRMForm(id);
            form.ShowDialog();

            if (form.OperationConfirmed != DialogResult.Yes) return;

            var taskAfterUpdate = new CRM_Task
            {
                TaskID = id,
                ContractorID = form.SelectedContractorID,
                CarID = form.SelectedVehicleID,
                StartDate = form.CreationDate,
                Completed = form.TaskClosed,
                EndDate = form.TaskClosed ? DateTime.Now : (DateTime?)null,
                MechanicID = taskBeforeUpdate.MechanicID,
                Comment = form.TaskComment,
                Price = Convert.ToDouble(form.TotalPrice)
            };

            var taskMappingsAfterUpdate = form.SelectedRequiredServiceID
                .Select(
                    serviceId => new CRM_Services
                    {
                        ID = serviceId,
                        TaskID = id,
                        ServiceID = serviceId,
                        Quantity = form.SelectedServiceQuantities != null && form.SelectedServiceQuantities.ContainsKey(serviceId)
                            ? form.SelectedServiceQuantities[serviceId]
                            : 1
                    })
                .ToList();

            if (_crms.FindIndex(t => t.TaskID == id) >= 0
                && _genericRepo.Update(taskAfterUpdate)
                && _genericRepo.UseRawSql(CarRepairShop.CRM.Queries.DeleteCRMTasks(taskBeforeUpdate.TaskID))
                && _genericRepo.Insert(taskMappingsAfterUpdate) > 0)
            {
                _models[_crms.FindIndex(t => t.TaskID == id)] = new CRM_Model
                {
                    ID = taskAfterUpdate.TaskID,
                    Description = taskAfterUpdate.Comment,
                    StartDate = taskAfterUpdate.StartDate.ToString("dd//MM/yyyy HH:mm"),
                    Completed = taskAfterUpdate.Completed,
                    EndDate = taskAfterUpdate.EndDate?.ToString("dd//MM/yyyy HH:mm") ?? string.Empty,
                    TaskCreatorFullname = $"{_mechanics.FirstOrDefault(c => c.ID == taskAfterUpdate.MechanicID).Name} {_contractors.FirstOrDefault(c => c.ID == taskAfterUpdate.MechanicID).Surname}",
                    CustomerFullname = $"{_contractors.FirstOrDefault(c => c.ID == taskAfterUpdate.ContractorID).Name} {_contractors.FirstOrDefault(c => c.ID == taskAfterUpdate.ContractorID).Surname}",
                    Price = (decimal)taskAfterUpdate.Price,
                    VehicleDetails = $"{_contractorsCars.FirstOrDefault(c => c.ID == taskAfterUpdate.CarID).BrandName} {_contractorsCars.FirstOrDefault(c => c.ID == taskAfterUpdate.CarID).ModelName} {_contractorsCars.FirstOrDefault(c => c.ID == taskAfterUpdate.CarID).Year}",
                    Services = string.Join(", ",
                        taskMappingsAfterUpdate
                            .Where(
                                cs => cs.TaskID == taskAfterUpdate.TaskID)
                            .Select(cs =>
                                {
                                    var service = _services.FirstOrDefault(s => s.ID == cs.ServiceID);
                                    return service != null ? $"{service.Name} x {cs.Quantity}" : null;
                                })
                            .Where(s => s != null))
                };

                _view.PopulateCRMTasksGrid(GetFilteredModels());
            }
            else
            {
                _view.ShowMessage("Task update has failed"); return;
            }
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (!_currentUserService.IsAdmin)
            {
                _view.ShowMessage("You have to have Super-Admin rights for this action!"); return;
            }

            var id = _view.SelectedCRMTaskID;
            var crmsToDelete = _crms.Where(c => c.TaskID == id).ToList();
            var crmServicesToDelete = _crmServices.Where(cs => cs.TaskID == id).ToList();

            _genericRepo.Delete(crmsToDelete);
            _genericRepo.Delete(crmServicesToDelete);
        }

        private void StartDebounce(object sender, EventArgs e) => _view.StartDebounce();

        private void FilterData(object sender, EventArgs e)
        {
            _view.StopDebounce();
            _view.PopulateCRMTasksGrid(GetFilteredModels());
        }


        private List<CRM_Model> GetFilteredModels()
        {
            if (_view.FilterDateFrom.Date > _view.FilterDateTo.Date)
                return new List<CRM_Model>();

            var filteredModels = _models
                .Where(crm =>
                {
                    DateTime startDate;
                    if (!DateTime.TryParseExact(crm.StartDate, "dd//MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out startDate))
                        return false;
                    return startDate >= _view.FilterDateFrom && startDate.Date <= _view.FilterDateTo.Date;
                })
                .ToList();

            if (!string.IsNullOrEmpty(_view.FilterContractorFullName))
                filteredModels = filteredModels
                    .Where(
                        crm => crm.CustomerFullname != null && crm.CustomerFullname.Contains(_view.FilterContractorFullName))
                    .ToList();

            if (!string.IsNullOrEmpty(_view.FilterMechanicFullName))
                filteredModels = filteredModels
                    .Where(
                        crm => crm.TaskCreatorFullname != null && crm.TaskCreatorFullname.Contains(_view.FilterMechanicFullName))
                    .ToList();

            if (_view.FilterShowAllChecked)
                return filteredModels;

            if (_view.FilterShowCompletedChecked)
                filteredModels = filteredModels
                    .Where(
                        crm => crm.Completed)
                    .ToList();

            if (_view.FilterShowNotCompletedChecked)
                filteredModels = filteredModels
                    .Where(
                        crm => !crm.Completed)
                    .ToList();

            return filteredModels;
        }
    }
}
