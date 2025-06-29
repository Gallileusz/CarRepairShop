using CarRepairShop.Repositories;
using CarRepairShop.Services.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.Services.Presenter
{
    public class ServicesFormPresenter
    {
        private IServicesForm _view;
        private GenericRepository _genericRepo;
        private Domain.Entities.Services _service;
        private bool _editMode = false;
        private bool _isConfirmed = false;
        private List<Domain.Entities.Services> _servicesList;

        public ServicesFormPresenter(IServicesForm view, int? serviceID)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _servicesList = _genericRepo.GetAll<Domain.Entities.Services>().ToList();

            if (serviceID.HasValue)
            {
                _service = _servicesList.FirstOrDefault(x => x.ID == serviceID.Value);
                _editMode = true;
                _view.FormTitle = $"Edycja usługi: {_service.Name}";
            }
            else
            {
                _service = null;
                _view.FormTitle = "Dodaj nową usługę";
            }

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += Load;
            _view.FormIsClosing += Close;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
        }

        private void Load(object sender, EventArgs e)
        {
            if (_service == null) return;

            _view.ServiceCost = _service.StandardCost;
            _view.ServiceDuration = _service.Duration;
            _view.ServiceWarrantyMonths = _service.WarrantyMonths;
            _view.ServiceName = _service.Name;
        }

        private void Close(object sender, EventArgs e)
        {
            if (!_isConfirmed)
                _service = null;
        }

        private void Confirm(object sender, EventArgs e)
        {
            _service = new Domain.Entities.Services()
            {
                StandardCost = _view.ServiceCost,
                Duration = _view.ServiceDuration,
                WarrantyMonths = _view.ServiceWarrantyMonths,
                Name = _view.ServiceName,
                IsActive = true
            };

            if (IsNewServiceInvalid(_service)) return;

            _isConfirmed = true;
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e)
        {
            _service = null;
            _view.CloseForm();
        }

        private bool IsNewServiceInvalid(Domain.Entities.Services service)
        {
            if (service == null) return true;

            if (string.IsNullOrWhiteSpace(service.Name))
            {
                _view.ShowMessage("Nazwa usługi nie może być pusta!"); return true;
            }
            if (service.WarrantyMonths < 0)
            {
                _view.ShowMessage("Gwarancja nie może być mniejsza niż 0 miesięcy!"); return true;
            }
            if (service.Duration < 0 || float.IsNaN(service.Duration))
            {
                _view.ShowMessage("Czas wykonania usługi nie może być mniejszy niż 0 godzin!"); return true;
            }
            if (service.StandardCost < 0 || float.IsNaN(service.StandardCost))
            {
                _view.ShowMessage("Uzepełnij pole cena usługi!"); return true;
            }
            if (_editMode == false && _servicesList.Any(x => x.Name == service.Name))
            {
                _view.ShowMessage("Usługa o tej nazwie już istnieje!"); return true;
            }

            return false;
        }
    }
}
