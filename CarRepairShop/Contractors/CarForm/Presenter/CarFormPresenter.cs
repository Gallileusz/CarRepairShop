using CarRepairShop.Contractors.CarForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Contractors.CarForm.Presenter
{
    public class CarFormPresenter
    {
        private readonly ICarForm _view;
        private readonly IGenericRepository _genericRepo;
        private readonly int? _id;

        private readonly List<FuelTypes> _fuelTypes;

        public CarFormPresenter(ICarForm view, IGenericRepository genericRepo, int? id)
        {
            _view = view;
            _genericRepo = genericRepo;
            _id = id;

            _fuelTypes = _genericRepo.GetAll<FuelTypes>().ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.PopulateFuelTypesCombobox(_fuelTypes);

            if (_id != null && _id.HasValue)
            {
                _view.CarFormResult = new DTO.CarFormResult
                {
                    Data = _genericRepo.GetAll<ContractorsCars>().FirstOrDefault(x => x.ID == _id),
                    OperationConfirmed = System.Windows.Forms.DialogResult.None
                };
            }
            else
                _view.CarFormResult = new DTO.CarFormResult
                {
                    Data = new ContractorsCars(),
                    OperationConfirmed = System.Windows.Forms.DialogResult.None
                };
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (IsCarDataInvalid(_view.CarFormResult.Data)) return;

            _view.CarFormResult = new DTO.CarFormResult
            {
                Data = _view.CarFormResult.Data,
                OperationConfirmed = System.Windows.Forms.DialogResult.Yes
            };

            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e) => _view.CloseForm();

        private bool IsCarDataInvalid(ContractorsCars car)
        {
            if (string.IsNullOrEmpty(car.BrandName))
            {
                _view.ShowMessage(Translations.CarForm.FillBrandField); return true;
            }
            if (string.IsNullOrEmpty(car.ModelName))
            {
                _view.ShowMessage(Translations.CarForm.FillModelField); return true;
            }
            if (string.IsNullOrEmpty(car.Year.ToString()))
            {
                _view.ShowMessage(Translations.CarForm.FillProductionYearField); return true;
            }
            if (string.IsNullOrEmpty(car.VIN.ToString()))
            {
                _view.ShowMessage(Translations.CarForm.FillVINField); return true;
            }
            if (string.IsNullOrEmpty(car.LicensePlate))
            {
                _view.ShowMessage(Translations.CarForm.FillLicensePlateField); return true;
            }
            if (string.IsNullOrEmpty(car.EngineCapacity.ToString()))
            {
                _view.ShowMessage(Translations.CarForm.FillEngineCapacityField); return true;
            }
            if (car.FuelTypeID < 0)
            {
                _view.ShowMessage(Translations.CarForm.SelectFuelType); return true;
            }
            if (string.IsNullOrEmpty(car.Mileage.ToString()))
            {
                _view.ShowMessage(Translations.CarForm.FillMileageField); return true;
            }

            return false;
        }
    }
}
