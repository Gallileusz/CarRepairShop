using CarRepairShop.AppSettings;
using CarRepairShop.MainForm.Views.Tabs.Services;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.MainForm.Presenters.Tabs.Services
{
    public class ServicesTabPresenter
    {
        private readonly IServicesTab _view;
        private readonly GenericRepository _genericRepo;
        private List<Domain.Entities.Services> _servicesList;
        private List<Domain.Entities.Services> _filteredServicesList;

        public ServicesTabPresenter(IServicesTab view)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _servicesList = _genericRepo.GetAll<Domain.Entities.Services>().ToList();
            _filteredServicesList = _servicesList;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += Load;
            _view.DebounceTimerElapsed += DebounceTimerElapsed;
            _view.FilterChanged += Filter;
            _view.ServiceStatusCheckboxClicked += ChangeServiceStatus;

            _view.AddServiceButtonClicked += AddService;
            _view.EditServiceButtonClicked += EditService;
            _view.DeleteServiceButtonClicked += DeleteService;
        }

        private void ChangeServiceStatus(object sender, EventArgs e)
        {
            if (!CurrentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.Permissions.AllowEdit))
            {
                _view.ShowMessage("Nie masz uprawnień do zmiany statusu usług!"); return;
            }

            var service = _servicesList.FirstOrDefault(x => x.ID == _view.SelectedServiceID);

            if (service == null)
            {
                _view.ShowMessage("Proszę wybrać usługę do edycji."); return;
            }

            if (!_view.ConfirmAction($"Czy na pewno chcesz zmienić status usługi: {service.Name}?", "Potwierdzenie zmiany statusu usługi.")) return;

            service.IsActive = !service.IsActive;

            if (_genericRepo.Update(service))
            {
                var status = service.IsActive ? "aktywny" : "nieaktywny";
                _view.LoadServicesToGrid(_servicesList);
                _view.ShowMessage($"Pomyślnie zaktualizowano status usługi: {service.Name} na {status}.");
            }
            else
                _view.ShowMessage($"Nie udało się zaktualizować statusu usługi: {service.Name}!");
        }

        private void Load(object sender, EventArgs e)
        {
            _view.LoadServicesToGrid(_servicesList.Where(x => x.IsActive).ToList());
            _view.UnableButtonsIfUserDoesntHavePermissions(CurrentUser.HasPermission(Utilities.Permissions.PermissionTabs.Services, Utilities.Permissions.Permissions.AllowEdit));
        }

        private void DebounceTimerElapsed(object sender, EventArgs e) => _view.LoadServicesToGrid(_filteredServicesList);

        private void Filter(object sender, EventArgs e)
        {
            _filteredServicesList = _servicesList;

            if (!string.IsNullOrEmpty(_view.SearchedServiceName))
                _filteredServicesList = _filteredServicesList.Where(x => x.Name.ToLower().Contains(_view.SearchedServiceName.ToLower())).ToList();

            if (_view.AllStatusesRadioButtonStatus) return;

            if (_view.ActiveServicesRadioButtonStatus)
                _filteredServicesList = _filteredServicesList.Where(x => x.IsActive).ToList();
            else if (_view.InactiveServicesRadioButtonStatus)
                _filteredServicesList = _filteredServicesList.Where(x => !x.IsActive).ToList();
        }

        private void AddService(object sender, EventArgs e)
        {
            var form = new CarRepairShop.Services.View.SerivcesForm(null);
            form.ShowDialog();

            var service = new Domain.Entities.Services
            {
                Name = form.ServiceName,
                StandardCost = form.ServiceCost,
                Duration = form.ServiceDuration,
                WarrantyMonths = form.ServiceWarrantyMonths,
                IsActive = true
            };

            if (IsServiceInvalid(service)) return;


            if (_genericRepo.Insert(service) > 0)
            {
                _servicesList.Add(service);
                _view.LoadServicesToGrid(_servicesList);
                _view.ShowMessage("Pomyślnie dodano nową usługę.");
            }
            else
                _view.ShowMessage($"Nie udało się dodać nowej usługi: {service.Name}!");
        }

        private void EditService(object sender, EventArgs e)
        {
            var serviceBeforeUpdate = _servicesList.FirstOrDefault(x => x.ID == _view.SelectedServiceID);

            if (serviceBeforeUpdate == null)
            {
                _view.ShowMessage("Proszę wybrać usługę do edycji."); return;
            }

            var form = new CarRepairShop.Services.View.SerivcesForm(serviceBeforeUpdate.ID);
            form.ShowDialog();

            var service = new Domain.Entities.Services
            {
                Name = form.ServiceName,
                StandardCost = form.ServiceCost,
                Duration = form.ServiceDuration,
                WarrantyMonths = form.ServiceWarrantyMonths,
                IsActive = true,
                ID = serviceBeforeUpdate.ID
            };

            if (IsServiceInvalid(service) || AreServicesEqual(serviceBeforeUpdate, service)) return;

            var serviceIndex = _servicesList.FindIndex(x => x.ID == service.ID);

            if (serviceIndex >= 0 && _genericRepo.Update(service))
            {
                _servicesList[serviceIndex] = service;
                _view.LoadServicesToGrid(_servicesList);
                _view.ShowMessage("Pomyślnie zaktualizowano usługę.");
            }
            else
                _view.ShowMessage($"Nie udało się zaktualiuzować usługi: {service.Name}!");
        }

        private void DeleteService(object sender, EventArgs e)
        {
            var service = _servicesList.FirstOrDefault(x => x.ID == _view.SelectedServiceID);

            if (service == null)
            {
                _view.ShowMessage("Proszę wybrać użytkownika do edycji."); return;
            }

            if (!_view.ConfirmAction($"Czy na pewno chcesz usunąć usługę: {service.Name}?", "Potwierdzenie usunięcia usługi?")) return;

            if (_genericRepo.Delete(service))
            {
                _servicesList.Remove(service);
                _view.LoadServicesToGrid(_servicesList);
                _view.ShowMessage("Pomyślnie usunięto usługę.");
            }
            else
                _view.ShowMessage($"Nie udało się usunąć usługi: {service.Name}!");
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
