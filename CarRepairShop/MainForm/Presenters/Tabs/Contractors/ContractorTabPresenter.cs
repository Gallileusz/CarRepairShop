using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.Contractors;
using CarRepairShop.MainForm.Views.Tabs.Contractors;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Presenters.Tabs.Contractors
{
    public class ContractorTabPresenter
    {
        private IContractorsTab _view;
        private IGenericRepository _genericRepo;
        private ICurrentUserService _currentUser;

        private List<Domain.Entities.Contractors> _contractors;
        private List<ContractorsCars> _cars;
        private List<FuelTypes> _fuelTypes;

        public ContractorTabPresenter(IContractorsTab view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;

            _contractors = _genericRepo.GetAll<Domain.Entities.Contractors>().ToList();
            _cars = _genericRepo.GetAll<ContractorsCars>().ToList();
            _fuelTypes = _genericRepo.GetAll<FuelTypes>().ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.DebounceElapsed += DebounceElapsed;
            _view.FuelTypesButtonClicked += OpenFuelTypesDictionary;
            _view.FilterChanged += FilterData;

            _view.AddContractorButtonClicked += AddContractor;
            _view.EditContractorButtonClicked += EditContractor;
            _view.DeleteContractorButtonClicked += DeleteContractor;
            _view.ContractorSelectionChanged += ContractorChanged;

            _view.AddCarButtonClicked += AddCar;
            _view.EditCarButtonClicked += EditCar;
            _view.DeleteCarButtonClicked += DeleteCar;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.StopDebounce();

            _view.FilterChanged -= FilterData;
            _view.ContractorSelectionChanged -= ContractorChanged;

            _view.LoadContractorsToGrid(GetFilteredContractors());
            _view.LoadContractorsCarsToGrid(GetFilteredCarsVMs());
            _view.ChangeButtonAccess(_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit));

            if (_view is Control control)
                control.BeginInvoke(new Action(() => _view.ResetGridSelections())); // Needs UI thread invoke on load

            _view.ContractorSelectionChanged += ContractorChanged;
            _view.FilterChanged += FilterData;
        }

        private void DebounceElapsed(object sender, EventArgs e)
        {
            _view.StopDebounce();

            _view.LoadContractorsToGrid(GetFilteredContractors());
            _view.LoadContractorsCarsToGrid(GetFilteredCarsVMs());

            _view.ResetGridSelections();
        }

        private void FilterData(object sender, EventArgs e) => _view.StartDebounce();

        private List<Domain.Entities.Contractors> GetFilteredContractors()
        {
            var filtered = _contractors;

            if (!string.IsNullOrEmpty(_view.SearchedContractorName))
                filtered = filtered.Where(x => x.Name.ToLower().Contains(_view.SearchedContractorName.ToLower())).ToList();

            if (!string.IsNullOrEmpty(_view.SearchedContractorSurname))
                filtered = filtered.Where(x => x.Surname.ToLower().Contains(_view.SearchedContractorSurname.ToLower())).ToList();

            return filtered;
        }

        private List<ContractorCarsVM> GetFilteredCarsVMs()
        {
            if (_view.SelectedContractorID <= 0) return new List<ContractorCarsVM>();

            var filteredCars = _cars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList();

            if (!string.IsNullOrEmpty(_view.SearchedCarBrandName))
                filteredCars = filteredCars.Where(x => x.BrandName.ToLower().Contains(_view.SearchedCarBrandName.ToLower())).ToList();

            if (!string.IsNullOrEmpty(_view.SearchedCarModelName))
                filteredCars = filteredCars.Where(x => x.ModelName.ToLower().Contains(_view.SearchedCarModelName.ToLower())).ToList();

            return filteredCars.Select(x => new ContractorCarsVM(x, _fuelTypes)).ToList();
        }

        private void ContractorChanged(object sender, EventArgs e)
        {
            if (_view.SelectedContractorID < 0) return;

            _view.LoadContractorsCarsToGrid(GetFilteredCarsVMs());
        }

        private void AddContractor(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            var result = _view.OpenContractorForm(null, Translations.MainView.Contractors.AddNewContractor);

            if (result.OperationConfirmed != DialogResult.Yes) return;

            var newContractor = result.Contractor;

            if (newContractor == null || IsContractorInvalid(newContractor)) return;

            if (_genericRepo.Insert(newContractor) > 0)
            {
                _contractors.Add(newContractor);
                _view.ShowMessage(Translations.MainView.Contractors.ContractorInsertSuccess);
                _view.LoadContractorsToGrid(GetFilteredContractors());
                _view.ResetGridSelections();
            }
            else
                _view.ShowMessage(Translations.MainView.Contractors.ContractorInsertError);
        }

        private void EditContractor(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            if (_view.SelectedContractorID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);

            var result = _view.OpenContractorForm(contractor.ID, string.Format(Translations.MainView.Contractors.EditContractor, contractor.Name, contractor.Surname));

            if (result.OperationConfirmed != DialogResult.Yes) return;

            var editedContractor = result.Contractor;
            editedContractor.ID = contractor.ID;

            if (editedContractor == null || IsContractorInvalid(editedContractor)) return;

            var contractorIndex = _contractors.IndexOf(contractor);

            if (contractorIndex >= 0 && _genericRepo.Update(editedContractor))
            {
                _contractors[contractorIndex] = editedContractor;
                _view.ShowMessage(Translations.MainView.Contractors.EditContractorSuccess);
                _view.LoadContractorsToGrid(GetFilteredContractors());
                _view.ResetGridSelections();
            }
            else
                _view.ShowMessage(Translations.MainView.Contractors.EditContractorError);
        }

        private void DeleteContractor(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            if (_view.SelectedContractorID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);
            var contractorsCars = _cars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList();

            if (!_view.ConfirmAction(string.Format(Translations.MainView.Contractors.DeleteContractorConfirmationBody, contractor.Name, contractor.Surname), Translations.MainView.Contractors.DeleteContractorConfirmationTitle)) return;

            if (contractorsCars.Any())
            {
                if (_genericRepo.Delete(contractorsCars))
                    _cars.RemoveAll(car => car.ContractorID == _view.SelectedContractorID);
                else
                {
                    _view.ShowMessage(Translations.MainView.Contractors.DeleteContractorsCarsError); return;
                }
            }

            if (_genericRepo.Delete(contractor))
            {
                _contractors.Remove(contractor);
                _view.ShowMessage(Translations.MainView.Contractors.DeleteContractorSuccess);
                _view.LoadContractorsToGrid(GetFilteredContractors());
                _view.ResetGridSelections();
            }
            else
                _view.ShowMessage(Translations.MainView.Contractors.DeleteContractorError);
        }

        private void AddCar(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            if (_view.SelectedContractorID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);

            var result = _view.OpenCarForm(null, string.Format(Translations.MainView.Contractors.AddNewCar, contractor.Name, contractor.Surname));

            if (result.OperationConfirmed != DialogResult.Yes) return;

            if (result.Data == null) return;

            result.Data.ContractorID = _view.SelectedContractorID;

            if (result.Data == null || IsCarInvalid(result.Data)) return;

            if (_genericRepo.Insert(result.Data) > 0)
            {
                _cars.Add(result.Data);
                _view.ShowMessage(Translations.MainView.Contractors.CarInsertSuccess);
                _view.LoadContractorsToGrid(GetFilteredContractors());
                _view.ResetGridSelections();
            }
            else
                _view.ShowMessage(Translations.MainView.Contractors.CarInsertError);
        }

        private void EditCar(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            if (_view.SelectedContractorID < 0 || _view.SelectedCarID < 0) return;

            var contractor = _contractors.FirstOrDefault(x => x.ID == _view.SelectedContractorID);
            var car = _cars.FirstOrDefault(x => x.ID == _view.SelectedCarID);

            var result = _view.OpenCarForm(car.ID, string.Format(Translations.MainView.Contractors.EditCar, car.BrandName, car.ModelName));

            if (result.OperationConfirmed != DialogResult.Yes) return;

            if (result.Data == null) return;

            result.Data.ContractorID = _view.SelectedContractorID;

            if (car == result.Data || IsCarInvalid(result.Data)) return;

            var carIndex = _cars.IndexOf(car);

            if (carIndex >= 0 && _genericRepo.Update(result.Data))
            {
                _cars[carIndex] = result.Data;
                _view.ShowMessage(Translations.MainView.Contractors.EditCarSuccess);
                _view.LoadContractorsToGrid(GetFilteredContractors());
                _view.ResetGridSelections();
            }
            else
                _view.ShowMessage(Translations.MainView.Contractors.EditCarError);
        }

        private void DeleteCar(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            if (_view.SelectedContractorID < 0 || _view.SelectedCarID < 0) return;

            var car = _cars.FirstOrDefault(x => x.ID == _view.SelectedCarID);

            var taskMappings = _genericRepo.GetSingle<CRM_Task>($"WHERE {nameof(CRM_Task.CarID)} = {car.ID}");

            if (taskMappings != null)
            {
                _view.ShowMessage(Translations.MainView.Contractors.CarHasTaskMappingsError); return;
            }

            if (!_view.ConfirmAction(string.Format(Translations.MainView.Contractors.DeleteCarConfirmationBody, car.BrandName, car.ModelName), Translations.MainView.Contractors.DeleteCarConfirmationTitle)) return;

            if (_genericRepo.Delete(car))
            {
                _cars.Remove(car);
                _view.ShowMessage(Translations.MainView.Contractors.DeleteCarSuccess);
                _view.LoadContractorsToGrid(GetFilteredContractors());
                _view.ResetGridSelections();
            }
            else
                _view.ShowMessage(Translations.MainView.Contractors.DeleteCarError);
        }

        private void OpenFuelTypesDictionary(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowDisplay)) return;

            var providedChanges = _view.OpenFuelTypesDictionary();

            if (providedChanges != DialogResult.Yes) return;

            _fuelTypes = _genericRepo.GetAll<FuelTypes>().ToList();

            _view.LoadContractorsToGrid(GetFilteredContractors());
            _view.ResetGridSelections();
        }

        private bool IsContractorInvalid(Domain.Entities.Contractors contractor)
        {
            if (_contractors.Contains(contractor))
            {
                _view.ShowMessage(Translations.MainView.Contractors.ContractorExistsError); return true;
            }

            return false;
        }

        private bool IsCarInvalid(ContractorsCars car)
        {
            var contractorsCars = _cars.Where(x => x.ContractorID == _view.SelectedContractorID).ToList();

            if (contractorsCars.Any(existingCar => AreCarsEqualIgnoringId(existingCar, car)))
            {
                _view.ShowMessage(Translations.MainView.Contractors.ContractorsCarExistsError); return true;
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
                   firstCar.FuelTypeID == secondCar.FuelTypeID &&
                   firstCar.Mileage == secondCar.Mileage &&
                   firstCar.LicensePlate == secondCar.LicensePlate;
        }
    }
}
