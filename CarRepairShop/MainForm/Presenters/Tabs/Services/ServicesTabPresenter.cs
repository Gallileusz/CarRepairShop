using CarRepairShop.AppSettings;
using CarRepairShop.MainForm.Views.Tabs.Services;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Presenters.Tabs.Services
{
    public class ServicesTabPresenter
    {
        private readonly IServicesTab _view;
        private readonly IGenericRepository _genericRepo;
        private readonly ICurrentUserService _currentUser;

        private List<Domain.Entities.Services> _servicesList;

        public ServicesTabPresenter(IServicesTab view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;

            _servicesList = _genericRepo.GetAll<Domain.Entities.Services>().ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += Load;
            _view.DebounceElapsed += DebounceTimerElapsed;
            _view.FilterChanged += StartDebounce;
            _view.ServiceStatusCheckboxClicked += ChangeServiceStatus;

            _view.AddServiceButtonClicked += AddService;
            _view.EditServiceButtonClicked += EditService;
            _view.DeleteServiceButtonClicked += DeleteService;
        }

        private void Load(object sender, EventArgs e)
        {
            _view.StopDebounce();
            _view.LoadServicesToGrid(GetModels());
            _view.UnableButtonsIfUserDoesntHavePermissions(
                _currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.PermissionType.AllowEdit));
        }

        private void DebounceTimerElapsed(object sender, EventArgs e) => _view.LoadServicesToGrid(GetModels());

        private void StartDebounce(object sender, EventArgs e) => _view.StartDebounce();

        private void ChangeServiceStatus(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.PermissionType.AllowEdit))
            {
                _view.ShowMessage(Translations.MainView.Services.MissingEditPermissions); return;
            }

            var service = _servicesList.FirstOrDefault(x => x.ID == _view.SelectedServiceID);

            if (service == null)
            {
                _view.ShowMessage(Translations.MainView.Services.ServiceNotSelected); return;
            }

            if (!_view.ConfirmAction(string.Format(Translations.MainView.Services.ConfirmServiceStatusChangeBody, service.Name), Translations.MainView.Services.ConfirmServiceStatusChangeTitle)) return;

            service.IsActive = !service.IsActive;

            if (_genericRepo.Update(service))
            {
                var status = service.IsActive ? Translations.MainView.Services.Active : Translations.MainView.Services.Inactive;
                _view.LoadServicesToGrid(GetModels());
                _view.ShowMessage(string.Format(Translations.MainView.Services.StatusChangeSuccess, service.Name, status));
            }
            else
                _view.ShowMessage(string.Format(Translations.MainView.Services.StatusChangeError, service.Name));
        }

        private void AddService(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var serviceDto = _view.ShowServiceForm(null);
            if (serviceDto.OperationConfirmed != System.Windows.Forms.DialogResult.Yes) return;

            var service = serviceDto.Service;

            if (IsServiceInvalid(service)) return;

            if (_genericRepo.Insert(service) > 0)
            {
                _servicesList.Add(service);
                _view.LoadServicesToGrid(GetModels());
                _view.ShowMessage(Translations.MainView.Services.InsertSuccess);
            }
            else
                _view.ShowMessage(Translations.MainView.Services.InsertError);
        }

        private void EditService(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var serviceBeforeUpdate = _servicesList.FirstOrDefault(x => x.ID == _view.SelectedServiceID);

            if (serviceBeforeUpdate == null)
            {
                _view.ShowMessage(Translations.MainView.Services.ServiceNotSelected); return;
            }

            var serviceDto = _view.ShowServiceForm(serviceBeforeUpdate.ID);
            if (serviceDto.OperationConfirmed != System.Windows.Forms.DialogResult.Yes) return;

            var service = serviceDto.Service;
            service.ID = serviceBeforeUpdate.ID;

            if (IsServiceInvalid(service) || AreServicesEqual(serviceBeforeUpdate, service)) return;

            var serviceIndex = _servicesList.FindIndex(x => x.ID == service.ID);

            if (serviceIndex >= 0 && _genericRepo.Update(service))
            {
                _servicesList[serviceIndex] = service;
                _view.LoadServicesToGrid(GetModels());
                _view.ShowMessage(Translations.MainView.Services.UpdateSuccess);
            }
            else
                _view.ShowMessage(string.Format(Translations.MainView.Services.UpdateError, service.Name));
        }

        private void DeleteService(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var service = _servicesList.FirstOrDefault(x => x.ID == _view.SelectedServiceID);

            if (service == null)
            {
                _view.ShowMessage(Translations.MainView.Services.ServiceNotSelected); return;
            }

            if (!_view.ConfirmAction(string.Format(Translations.MainView.Services.DeleteConfirmBody, service.Name), Translations.MainView.Services.DeleteConfirmTitle)) return;

            if (_genericRepo.Delete(service))
            {
                _servicesList.Remove(service);
                _view.LoadServicesToGrid(GetModels());
                _view.ShowMessage(Translations.MainView.Services.DeleteSuccess);
            }
            else
                _view.ShowMessage(string.Format(Translations.MainView.Services.DeleteError, service.Name));
        }

        private List<Domain.Entities.Services> GetModels()
        {
            var filteredServices = _servicesList;

            if (!string.IsNullOrEmpty(_view.SearchedServiceName))
                filteredServices = filteredServices.Where(x => x.Name.ToLower().Contains(_view.SearchedServiceName.ToLower())).ToList();

            if (_view.AllStatusesRadioButtonStatus) return filteredServices;

            if (_view.ActiveServicesRadioButtonStatus)
                filteredServices = filteredServices.Where(x => x.IsActive).ToList();

            else if (_view.InactiveServicesRadioButtonStatus)
                filteredServices = filteredServices.Where(x => !x.IsActive).ToList();

            return filteredServices;
        }

        private bool IsServiceInvalid(Domain.Entities.Services service)
        {
            if (service == null) return true;
            if (string.IsNullOrEmpty(service.Name)) return true;
            if (service.StandardCost <= 0) return true;
            if (service.Duration <= 0) return true;
            if (service.WarrantyMonths < 0) return true;

            return false;
        }

        private bool AreServicesEqual(Domain.Entities.Services baseService, Domain.Entities.Services serviceAfterUpdate)
        {
            if (baseService == null && serviceAfterUpdate == null) return true;
            if (baseService == null || serviceAfterUpdate == null) return false;

            return baseService.Name == serviceAfterUpdate.Name &&
                   baseService.StandardCost == serviceAfterUpdate.StandardCost &&
                   baseService.Duration == serviceAfterUpdate.Duration &&
                   baseService.WarrantyMonths == serviceAfterUpdate.WarrantyMonths;
        }
    }
}
