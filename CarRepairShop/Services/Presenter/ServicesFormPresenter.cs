using CarRepairShop.Repositories;
using CarRepairShop.Services.View;
using System;
using System.Collections.Generic;
using System.Linq;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Services.Presenter
{
    public class ServicesFormPresenter
    {
        private IServicesForm _view;
        private IGenericRepository _genericRepo;

        private readonly List<Domain.Entities.Services> _servicesList;
        private Domain.Entities.Services _service;
        private bool _editMode = false;
        private bool _isConfirmed = false;

        public ServicesFormPresenter(IServicesForm view, IGenericRepository genericRepo, int? serviceID)
        {
            _view = view;
            _genericRepo = genericRepo;

            _servicesList = _genericRepo.GetAll<Domain.Entities.Services>().ToList();

            if (serviceID.HasValue)
            {
                _service = _servicesList.FirstOrDefault(x => x.ID == serviceID.Value);
                _editMode = true;
                _view.FormTitle = string.Format(Translations.ServicesForm.EditServiceTitle, _service.Name);
            }
            else
            {
                _service = null;
                _view.FormTitle = Translations.ServicesForm.NewServiceTitle;
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
            _view.Active = _service.IsActive;
        }

        private void Close(object sender, EventArgs e)
        {
            if (!_isConfirmed)
                _view.OperationConfirmed = System.Windows.Forms.DialogResult.No;
        }

        private void Confirm(object sender, EventArgs e)
        {
            _service = new Domain.Entities.Services()
            {
                StandardCost = _view.ServiceCost,
                Duration = _view.ServiceDuration,
                WarrantyMonths = _view.ServiceWarrantyMonths,
                Name = _view.ServiceName,
                IsActive = _view.Active
            };

            if (IsNewServiceInvalid(_service)) return;

            _isConfirmed = true;
            _view.OperationConfirmed = System.Windows.Forms.DialogResult.Yes;
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e)
        {
            _view.OperationConfirmed = System.Windows.Forms.DialogResult.No;
            _view.CloseForm();
        }

        private bool IsNewServiceInvalid(Domain.Entities.Services service)
        {
            if (service == null) return true;

            if (string.IsNullOrWhiteSpace(service.Name))
            {
                _view.ShowMessage(Translations.ServicesForm.PleaseProvideServiceName); return true;
            }
            if (service.WarrantyMonths < 0)
            {
                _view.ShowMessage(Translations.ServicesForm.PleaseProvideServiceWarrantyTime); return true;
            }
            if (service.Duration < 0 || float.IsNaN(service.Duration))
            {
                _view.ShowMessage(Translations.ServicesForm.PleaseProvideServiceDurationTime); return true;
            }
            if (service.StandardCost < 0 || float.IsNaN(service.StandardCost))
            {
                _view.ShowMessage(Translations.ServicesForm.PleaseProvideServicePrice); return true;
            }
            if (_editMode == false && _servicesList.Any(x => x.Name == service.Name))
            {
                _view.ShowMessage(Translations.ServicesForm.ServiceWithThisNameExistsAlready); return true;
            }

            return false;
        }
    }
}
