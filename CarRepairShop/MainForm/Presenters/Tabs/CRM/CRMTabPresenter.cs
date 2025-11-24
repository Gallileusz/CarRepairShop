using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.CRM;
using CarRepairShop.MainForm.Views.Tabs.CRM;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Presenters.Tabs.CRM
{
    public class CRMTabPresenter
    {
        private ICRMTab _view;
        private IGenericRepository _genericRepo;
        private ICurrentUserService _currentUserService;

        private const string _dateFormat = "dd.MM.yyyy HH:mm";

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
                StartDate = crm.StartDate.ToString(_dateFormat),
                Completed = crm.Completed,
                EndDate = crm.EndDate?.ToString(_dateFormat) ?? string.Empty,
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
            var currentWeekMonday = DateTime.Now.AddDays(-(int)(DateTime.Now.DayOfWeek == DayOfWeek.Sunday ? 6 : DateTime.Now.DayOfWeek - DayOfWeek.Monday));

            _view.FilterDateFrom = currentWeekMonday;
            _view.StopDebounce();
            _view.PopulateCRMTasksGrid(GetModels());
            _view.ChangeButtonAccess(_currentUserService.HasPermission(Utilities.Permissions.PermissionTabs.CRM, Utilities.Permissions.PermissionType.AllowEdit));
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            if (!_currentUserService.HasPermission(Utilities.Permissions.PermissionTabs.CRM, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var data = _view.OpenCRMForm();

            if (data.OperationConfirmed != DialogResult.Yes) return;

            if (_genericRepo.Insert(data.CRM_Task) < 0)
            {
                _view.ShowMessage(Translations.MainView.CRM.TaskInsertFailed);
                return;
            }

            data.CRM_Services.ForEach(s => s.TaskID = data.CRM_Task.TaskID);

            if (_genericRepo.Insert(data.CRM_Services) < 0)
            {
                _view.ShowMessage(Translations.MainView.CRM.TaskMappingsInsertFailed); return;
            }

            _crms.Add(data.CRM_Task);
            _crmServices.AddRange(data.CRM_Services);
            _models.Add(new CRM_Model
            {
                ID = data.CRM_Task.TaskID,
                Description = data.CRM_Task.Comment,
                StartDate = data.CRM_Task.StartDate.ToString(_dateFormat),
                Completed = data.CRM_Task.Completed,
                EndDate = null,
                TaskCreatorFullname = $"{_mechanics.FirstOrDefault(c => c.ID == data.CRM_Task.MechanicID).Name} {_mechanics.FirstOrDefault(c => c.ID == data.CRM_Task.MechanicID).Surname}",
                CustomerFullname = $"{_contractors.FirstOrDefault(c => c.ID == data.CRM_Task.ContractorID).Name} {_contractors.FirstOrDefault(c => c.ID == data.CRM_Task.ContractorID).Surname}",
                Price = (decimal)data.CRM_Task.Price,
                VehicleDetails = $"{_contractorsCars.FirstOrDefault(c => c.ID == data.CRM_Task.CarID).BrandName} {_contractorsCars.FirstOrDefault(c => c.ID == data.CRM_Task.CarID).ModelName} {_contractorsCars.FirstOrDefault(c => c.ID == data.CRM_Task.CarID).Year}",
                Services = string.Join(", ",
                    _crmServices
                        .Where(
                            cs => cs.TaskID == data.CRM_Task.TaskID)
                        .Select(cs =>
                            {
                                var service = _services.FirstOrDefault(s => s.ID == cs.ServiceID);
                                return service != null ? $"{service.Name} x {cs.Quantity}" : null;
                            })
                        .Where(s => s != null))
            });

            _view.PopulateCRMTasksGrid(GetModels());
            _view.ShowMessage(Translations.MainView.CRM.TaskInsertSuccess); return;
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            if (!_currentUserService.HasPermission(Utilities.Permissions.PermissionTabs.CRM, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var id = _view.SelectedCRMTaskID;
            var taskBeforeUpdate = _crms.Where(x => x.TaskID == id).FirstOrDefault();
            var taskMappingsBeforeUpdate = _crmServices.Where(x => x.TaskID == id).ToList();

            if (taskBeforeUpdate.EndDate != null
                && !_view.ConfirmAction(Translations.MainView.CRM.ReadOnlyViewBody, Translations.MainView.CRM.ReadOnlyViewTitle)) return;

            var data = _view.OpenCRMForm(id);

            if (data.OperationConfirmed != DialogResult.Yes) return;

            if (taskBeforeUpdate.EndDate != null) return;

            data.CRM_Task.TaskID = id;
            data.CRM_Services.ForEach(s => s.TaskID = data.CRM_Task.TaskID);

            if (_crms.FindIndex(t => t.TaskID == id) >= 0
                && _genericRepo.Update(data.CRM_Task)
                && _genericRepo.UseRawSql(CarRepairShop.CRM.Queries.DeleteMappings(data.CRM_Task.TaskID))
                && _genericRepo.Insert(data.CRM_Services) > 0)
            {
                _models[_crms.FindIndex(t => t.TaskID == id)] = new CRM_Model
                {
                    ID = data.CRM_Task.TaskID,
                    Description = data.CRM_Task.Comment,
                    StartDate = data.CRM_Task.StartDate.ToString(_dateFormat),
                    Completed = data.CRM_Task.Completed,
                    EndDate = data.CRM_Task.EndDate?.ToString(_dateFormat) ?? string.Empty,
                    TaskCreatorFullname = $"{_mechanics.FirstOrDefault(c => c.ID == data.CRM_Task.MechanicID).Name} {_mechanics.FirstOrDefault(c => c.ID == data.CRM_Task.MechanicID).Surname}",
                    CustomerFullname = $"{_contractors.FirstOrDefault(c => c.ID == data.CRM_Task.ContractorID).Name} {_contractors.FirstOrDefault(c => c.ID == data.CRM_Task.ContractorID).Surname}",
                    Price = (decimal)data.CRM_Task.Price,
                    VehicleDetails = $"{_contractorsCars.FirstOrDefault(c => c.ID == data.CRM_Task.CarID).BrandName} {_contractorsCars.FirstOrDefault(c => c.ID == data.CRM_Task.CarID).ModelName} {_contractorsCars.FirstOrDefault(c => c.ID == data.CRM_Task.CarID).Year}",
                    Services = string.Join(", ",
                        data.CRM_Services
                            .Where(
                                cs => cs.TaskID == data.CRM_Task.TaskID)
                            .Select(cs =>
                                {
                                    var service = _services.FirstOrDefault(s => s.ID == cs.ServiceID);
                                    return service != null ? $"{service.Name} x {cs.Quantity}" : null;
                                })
                            .Where(s => s != null))
                };

                _view.PopulateCRMTasksGrid(GetModels());
                _view.ShowMessage(Translations.MainView.CRM.UpdateSuccess); return;
            }
            else
            {
                _view.ShowMessage(Translations.MainView.CRM.UpdateError); return;
            }
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (!_currentUserService.IsAdmin)
            {
                _view.ShowMessage(Translations.MainView.CRM.MissingSuperAdminPermissions); return;
            }

            if (!_view.ConfirmAction(Translations.MainView.CRM.DeleteConfirmBody, Translations.MainView.CRM.DeleteConfirmTitle)) return;

            var crm = _crms.FirstOrDefault(c => c.TaskID == _view.SelectedCRMTaskID);
            var serviceMappings = _crmServices.Where(cs => cs.TaskID == _view.SelectedCRMTaskID).ToList();

            if (!_genericRepo.Delete(crm))
            {
                _view.ShowMessage(Translations.MainView.CRM.DeleteTaskError); return;
            }

            _genericRepo.Delete(serviceMappings);
            if (serviceMappings?.Any() == true)
                _models.RemoveAll(m => m.ID == _view.SelectedCRMTaskID);
            _view.PopulateCRMTasksGrid(GetModels());

            _view.ShowMessage(Translations.MainView.CRM.DeleteSuccess);
        }

        private void StartDebounce(object sender, EventArgs e) => _view.StartDebounce();

        private void FilterData(object sender, EventArgs e)
        {
            _view.StopDebounce();
            _view.PopulateCRMTasksGrid(GetModels());
        }

        private List<CRM_Model> GetModels()
        {
            if (_view.FilterDateFrom.Date > _view.FilterDateTo.Date)
                return new List<CRM_Model>();

            var filteredModels = _models
                .Where(crm =>
                {
                    if (!DateTime.TryParseExact(
                            crm.StartDate,
                            _dateFormat,
                            System.Globalization.CultureInfo.CurrentCulture,
                            System.Globalization.DateTimeStyles.None,
                            out DateTime startDate))
                        return false;

                    var date = startDate.Date;
                    return date >= _view.FilterDateFrom.Date &&
                           date <= _view.FilterDateTo.Date;
                })
                .ToList();

            if (!string.IsNullOrEmpty(_view.FilterContractorFullName))
                filteredModels = filteredModels
                    .Where(crm =>
                        crm.CustomerFullname != null &&
                        crm.CustomerFullname.Contains(_view.FilterContractorFullName))
                    .ToList();

            if (!string.IsNullOrEmpty(_view.FilterMechanicFullName))
                filteredModels = filteredModels
                    .Where(crm =>
                        crm.TaskCreatorFullname != null &&
                        crm.TaskCreatorFullname.Contains(_view.FilterMechanicFullName))
                    .ToList();

            if (_view.FilterShowAllChecked) return filteredModels;

            if (_view.FilterShowCompletedChecked)
                filteredModels = filteredModels
                    .Where(crm => crm.Completed)
                    .ToList();

            if (_view.FilterShowNotCompletedChecked)
                filteredModels = filteredModels
                    .Where(crm => !crm.Completed)
                    .ToList();

            return filteredModels;
        }
    }
}
