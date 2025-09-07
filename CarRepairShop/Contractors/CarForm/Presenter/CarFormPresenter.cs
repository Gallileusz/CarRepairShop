using CarRepairShop.Contractors.CarForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.Contractors.CarForm.Presenter
{
    public class CarFormPresenter
    {
        private ICarForm _view;
        private ContractorsCars _car;
        private bool _isConfirmed = false;
        private GenericRepository _genericRepo;
        List<FuelTypes> _fuelTypes;

        public CarFormPresenter(ICarForm view)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _fuelTypes = _genericRepo.GetAll<FuelTypes>().ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
            _view.FormIsClosing += Closing;
            _view.AddFuelTypeButtonClicked += AddFuelType;
        }

        private void AddFuelType(object sender, EventArgs e)
        {
            var form = new SingleInputForm("Podaj nazwę typu paliwa", string.Empty);
            form.ShowDialog();

            if (form.Value == null) return;

            var name = form.Value;

            if (IsNewFuelTypeNameInvalid(name)) return;

            var fuelType = new FuelTypes { Name = name };

            if (_genericRepo.Insert(fuelType) > 0)
            {
                _fuelTypes.Add(fuelType);
                _view.PopulateFuelTypesCombobox(_fuelTypes);
                _view.ShowMessage("Pomyślnie dodano nowy typ paliwa.");
            }
            else
                _view.ShowMessage($"Nie udało się dodać nowego typu paliwa: {name}!");
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.PopulateFuelTypesCombobox(_fuelTypes);

            if (_car != null)
            {
                _view.Car = _car;
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (_car == null)
                _car = new ContractorsCars();


            _car = _view.Car;

            if (IsContractorInvalid(_car)) return;

            _isConfirmed = true;
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e)
        {
            _car = null;
            _view.CloseForm();
        }

        private void Closing(object sender, EventArgs e)
        {
            if (!_isConfirmed)
                _car = null;
        }

        private bool IsContractorInvalid(ContractorsCars car)
        {
            if (string.IsNullOrEmpty(car.BrandName))
            {
                _view.ShowMessage("Uzupełnij pole: marka."); return true;
            }
            if (string.IsNullOrEmpty(car.ModelName))
            {
                _view.ShowMessage("Uzupełnij pole: model."); return true;
            }
            if (string.IsNullOrEmpty(car.Year.ToString()))
            {
                _view.ShowMessage("Uzupełnij pole: rocznik."); return true;
            }
            if (string.IsNullOrEmpty(car.VIN.ToString()))
            {
                _view.ShowMessage("Uzupełnij pole: VIN."); return true;
            }
            if (string.IsNullOrEmpty(car.LicensePlate))
            {
                _view.ShowMessage("Uzupełnij pole: tablica rejestracyjna."); return true;
            }
            if (string.IsNullOrEmpty(car.EngineCapacity.ToString()))
            {
                _view.ShowMessage("Usupełnij pole: pojemność silnika."); return true;
            }
            if (string.IsNullOrEmpty(car.FuelType))
            {
                _view.ShowMessage("Uzupełnij pole: typ paliwa."); return true;
            }
            if (string.IsNullOrEmpty(car.Mileage.ToString()))
            {
                _view.ShowMessage("Uzupełnij pole: przebieg."); return true;
            }

            return false;
        }

        public void SetCarData(ContractorsCars car) => _car = car;

        public ContractorsCars GetCarData() => _car;

        private bool IsNewFuelTypeNameInvalid(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                _view.ShowMessage("Nazwa nie może być pusta!"); return true;
            }

            if (_fuelTypes.Any(x => x.Name == name))
            {
                _view.ShowMessage("Taki typ paliwa już istnieje!"); return true;
            }

            return false;
        }
    }
}
