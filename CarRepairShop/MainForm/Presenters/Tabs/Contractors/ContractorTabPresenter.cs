using CarRepairShop.Contractors.CarForm.View;
using CarRepairShop.Contractors.ContractorForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Contractors;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.MainForm.Presenters.Tabs.Contractors
{
    public class ContractorTabPresenter
    {
        private IContractorsTab _view;
        private GenericRepository _genericRepo;
        private List<Domain.Entities.Contractors> _contractors;
        private Domain.Entities.Contractors _selectedContractor = new Domain.Entities.Contractors();
        private List<Domain.Entities.Contractors> _filteredContractors;
        private List<ContractorsCars> _cars;
        private List<ContractorsCars> _filteredCars;

        public ContractorTabPresenter(IContractorsTab view)
        {
            _view = view;
            _genericRepo = new GenericRepository();

            _contractors = _genericRepo.GetAll<Domain.Entities.Contractors>().ToList();
            _filteredContractors = _contractors;

            _cars = _genericRepo.GetAll<ContractorsCars>().ToList();
            _filteredCars = _cars;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += FormLoaded;
            _view.DebounceTimerElapsed += DebounceElapsed;

            _view.SearchBrandNameChanged += FilterCars;
            _view.SearchModelNameChanged += FilterCars;

            _view.SearchNameChanged += FilterContractors;
            _view.SearchSurameChanged += FilterContractors;

            _view.AddContractorButtonClicked += AddContractor;
            _view.EditContractorButtonClicked += EditContractor;
            _view.DeleteContractorButtonClicked += DeleteContractor;
            _view.ContractorSelectionChanged += ContractorChanged;

            _view.AddCarButtonClicked += AddCar;
            _view.EditCarButtonClicked += EditCar;
            _view.DeleteCarButtonClicked += DeleteCar;
        }

        private void DebounceElapsed(object sender, EventArgs e)
        {
            _view.LoadContractorsToGrid(_filteredContractors);

            if (_filteredContractors.Any())
            {
                int selectedContractorID = _view.SelectedContractorID;

                if (!_filteredContractors.Any(c => c.ID == selectedContractorID))
                {
                    selectedContractorID = _filteredContractors.First().ID;
                    _view.SelectContractorByID(selectedContractorID);
                }

                _view.LoadContractorsCarsToGrid(_filteredCars.Where(x => x.ContractorID == selectedContractorID).ToList());

                int selectedCarID = _view.SelectedCarID;

                var filteredCarsForContractor = _filteredCars.Where(x => x.ContractorID == selectedContractorID).ToList();

                if (!filteredCarsForContractor.Any(c => c.ID == selectedCarID) && filteredCarsForContractor.Any())
                {
                    selectedCarID = filteredCarsForContractor.First().ID;
                    _view.SelectCarByID(selectedCarID);
                }
                else if (filteredCarsForContractor.Any())
                    _view.SelectCarByID(selectedCarID);
            }
            else
            {
                _view.LoadContractorsCarsToGrid(new List<ContractorsCars>());
            }
        }

        private void FilterCars(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_view.SearchedCarBrandName))
                _filteredCars = _filteredCars
                    .Where(x => x.BrandName != null && x.BrandName.ToLower().Contains(_view.SearchedCarBrandName.ToLower()))
                    .ToList();

            if (!string.IsNullOrWhiteSpace(_view.SearchedCarModelName))
                _filteredCars = _filteredCars
                    .Where(x => x.ModelName != null && x.ModelName.ToLower().Contains(_view.SearchedCarModelName.ToLower()))
                    .ToList();
        }

        private void FilterContractors(object sender, EventArgs e)
        {
            _filteredContractors = _contractors;

            if (!string.IsNullOrEmpty(_view.SearchedContractorName))
                _filteredContractors = _filteredContractors.Where(x => x.Name.ToLower().Contains(_view.SearchedContractorName.ToLower())).ToList();

            if (!string.IsNullOrEmpty(_view.SearchedContractorSurname))
                _filteredContractors = _filteredContractors.Where(x => x.Surname.ToLower().Contains(_view.SearchedContractorSurname.ToLower())).ToList();
        }

        private void ContractorChanged(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0) return;

            _selectedContractor = _filteredContractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);
            _view.LoadContractorsCarsToGrid(_filteredCars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList());
        }

        private void FormLoaded(object sender, EventArgs e)
        {
            _view.SearchBrandNameChanged -= FilterCars;
            _view.SearchModelNameChanged -= FilterCars;
            _view.SearchNameChanged -= FilterContractors;
            _view.SearchSurameChanged -= FilterContractors;
            _view.ContractorSelectionChanged -= ContractorChanged;

            _view.LoadContractorsToGrid(_contractors);
            _view.LoadContractorsCarsToGrid(_cars.Where(x => x.ContractorID == _contractors.FirstOrDefault().ID).ToList());
            _view.UnableButtonsIfUserDoesntHavePermissions();

            _view.ContractorSelectionChanged += ContractorChanged;
            _view.SearchBrandNameChanged += FilterCars;
            _view.SearchModelNameChanged += FilterCars;
            _view.SearchNameChanged += FilterContractors;
            _view.SearchSurameChanged += FilterContractors;
        }

        private void LoadContractorsCars(object sender, EventArgs e)
        {
            _selectedContractor = _filteredContractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);
            _view.LoadContractorsCarsToGrid(_filteredCars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList());
        }

        private void AddContractor(object sender, EventArgs e)
        {
            var form = new ContractorForm(null);
            form.FormTitle = "Dodaj nowego kontrahenta";
            form.ShowDialog();

            var newContractor = form.GetContractor();

            if (newContractor == null || IsContractorInvalid(newContractor)) return;

            if (_genericRepo.Insert(newContractor) > 0)
            {
                _contractors.Add(newContractor);
                _view.ShowMessage("Udało się dodać nowego kontrahenta.");
                FormLoaded(sender, e);
            }
            else
                _view.ShowMessage("Nie udało się dodać nowego kontrahenta!");
        }

        private void EditContractor(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);

            var form = new ContractorForm(contractor);
            form.FormTitle = $"Edycja kontrahenta: {contractor.Name} {contractor.Surname}";
            form.ShowDialog();

            var editedContractor = form.GetContractor();

            if (editedContractor == null || IsContractorInvalid(editedContractor)) return;

            var contractorIndex = _contractors.IndexOf(contractor);

            if (contractorIndex > 0 && _genericRepo.Update(editedContractor))
            {
                _contractors[contractorIndex] = editedContractor;
                _view.ShowMessage("Udało się zaktualizować dane kontrahenta.");
                FormLoaded(sender, e);
            }
            else
                _view.ShowMessage("Nie udało się zaktualizować kontrahenta!");
        }

        private void DeleteContractor(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);
            var contractorsCars = _cars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList();

            if (!_view.ConfirmAction($"Czy na pewno chcesz usunąć kontrahenta:\r\n{contractor.Name} {contractor.Surname}\r\ni wszystkie jego samochody?\r\nOperacja jest nieodwracalna!", "Usuwanie kontrahenta")) return;

            if (contractorsCars.Any())
            {
                if (_genericRepo.Delete(contractorsCars))
                    _cars.RemoveAll(car => car.ContractorID == _view.SelectedContractorID);
                else
                {
                    _view.ShowMessage("Problem z usunięciem samochodów kontrahenta. Operacja została przerwana!"); return;
                }
            }

            if (_genericRepo.Delete(contractor))
            {
                _contractors.Remove(contractor);
                _view.ShowMessage("Udało się usunąć kontrahenta.");
                FormLoaded(sender, e);
            }
            else
                _view.ShowMessage("Nie udało się usunąć kontrahenta!");
        }

        private void AddCar(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);

            var form = new CarForm(null);
            form.FormTitle = $"Dodaj nowego samochód dla {contractor.Name} {contractor.Surname}";
            form.ShowDialog();

            var newContractorsCar = form.GetCarData();

            if (newContractorsCar == null) return;

            newContractorsCar.ContractorID = _view.SelectedContractorID;

            if (newContractorsCar == null || IsCarInvalid(newContractorsCar)) return;

            if (_genericRepo.Insert(newContractorsCar) > 0)
            {
                _cars.Add(newContractorsCar);
                _view.ShowMessage("Udało się dodać nowy samochód dla wybranego kontrahenta.");
                LoadContractorsCars(sender, e);
            }
            else
                _view.ShowMessage("Nie udało się dodać nowego samochodu dla wybranego kontrahenta!");
        }

        private void EditCar(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0 || _view.SelectedCarID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);
            var car = _cars.FirstOrDefault(x => x.ID == _view.SelectedCarID);

            var form = new CarForm(car);
            form.FormTitle = $"Edytuj samochód {contractor.Name} {contractor.Surname}";
            form.ShowDialog();

            var editedCar = form.GetCarData();

            if (editedCar == null) return;

            editedCar.ContractorID = _view.SelectedContractorID;

            if (car == editedCar || IsCarInvalid(editedCar)) return;

            var carIndex = _cars.IndexOf(car);

            if (_genericRepo.Update(editedCar))
            {
                _cars[carIndex] = editedCar; ;
                _view.ShowMessage("Udało się zaktualizować dane samochodu dla wybranego kontrahenta.");
                LoadContractorsCars(sender, e);
            }
            else
                _view.ShowMessage("Nie udało się zaktualizować danych samochodu dla wybranego kontrahenta!");
        }

        private void DeleteCar(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0 || _view.SelectedCarID < 0) return;

            var car = _cars.FirstOrDefault(x => x.ID == _view.SelectedCarID);

            if (!_view.ConfirmAction($"Czy na pewno chcesz usunąć samochód:\r\n{car.BrandName} {car.ModelName}\r\nOperacja jest nieodwracalna!", "Usuwanie samochodu")) return;

            if (_genericRepo.Delete(car))
            {
                _cars.Remove(car);
                _view.ShowMessage("Udało się usunąć samochód.");
                LoadContractorsCars(sender, e);
            }
            else
                _view.ShowMessage("Nie udało się usunąć samochodu!");
        }

        private bool IsContractorInvalid(Domain.Entities.Contractors contractor)
        {
            if (_contractors.Contains(contractor))
            {
                _view.ShowMessage("Taki kontrahent już istnieje."); return true;
            }

            return false;
        }

        private bool IsCarInvalid(ContractorsCars car)
        {
            var contractorsCars = _cars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList();

            if (contractorsCars.Any(existingCar => AreCarsEqualIgnoringId(existingCar, car)))
            {
                _view.ShowMessage("Ten kontrahent ma już taki przypisany ten samochód."); return true;
            }

            return false;
        }

        private bool AreCarsEqualIgnoringId(ContractorsCars firstCar, ContractorsCars secondCar)
        {
            return firstCar.ContractorID == secondCar.ContractorID &&
                   firstCar.BrandName == secondCar.BrandName &&
                   firstCar.ModelName == secondCar.ModelName &&
                   firstCar.VIN == secondCar.VIN &&
                   firstCar.Year == secondCar.Year &&
                   firstCar.EngineCapacity == secondCar.EngineCapacity &&
                   firstCar.FuelType == secondCar.FuelType &&
                   firstCar.Mileage == secondCar.Mileage &&
                   firstCar.LicensePlate == secondCar.LicensePlate;
        }
    }
}
