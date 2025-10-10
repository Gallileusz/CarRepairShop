using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Contractors.FuelTypesList.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Contractors.FuelTypesList.Presenter
{
    public class FuelTypesListPresenter
    {
        private readonly IFuelTypesList _view;
        private readonly IGenericRepository _genericRepo;
        private readonly ICurrentUserService _currentUser;
        private List<FuelTypes> _fuelTypes;

        public FuelTypesListPresenter(IFuelTypesList view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;
            _view.ChangesAccured = System.Windows.Forms.DialogResult.No;

            _fuelTypes = _genericRepo.GetAll<FuelTypes>().ToList();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += LoadData;
            _view.AddFuelTypeButtonClicked += AddType;
            _view.EditFuelTypeButtonClicked += EditType;
            _view.DeleteFuelTypeButtonClicked += DeleteType;
            _view.CloseButtonClicked += CloseForm;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.SetButtonsAccessability(_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit));
            _view.LoadFuelTypesToGrid(_fuelTypes);
        }

        private void AddType(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            var name = _view.ShowInputDialog(Translations.FuelTypesList.AddNewFuelType, string.Empty);

            if (string.IsNullOrWhiteSpace(name)) return;

            var newMaterialType = new FuelTypes { Name = name };
            if (_genericRepo.Insert(newMaterialType) > 0)
            {
                _view.ChangesAccured = System.Windows.Forms.DialogResult.Yes;
                _view.ShowMessage(string.Format(Translations.FuelTypesList.InsertSuccess, newMaterialType.Name));
                _fuelTypes.Add(newMaterialType);
                _view.LoadFuelTypesToGrid(_fuelTypes);
            }
            else
                _view.ShowMessage(string.Format(Translations.FuelTypesList.InsertFailed, newMaterialType.Name));
        }

        private void EditType(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            if (_view.SelectedID <= 0) return;

            var fuelType = _fuelTypes.FirstOrDefault(x => x.ID == _view.SelectedID);
            var index = _fuelTypes.FindIndex(x => x.ID == _view.SelectedID);
            if (fuelType == null || index < 0) return;

            var newName = _view.ShowInputDialog(Translations.FuelTypesList.EditFuelType, fuelType.Name);

            if (string.IsNullOrWhiteSpace(newName) || fuelType.Name == newName) return;

            if (!_view.ConfirmAction(string.Format(Translations.FuelTypesList.EditConfirmationBody, fuelType.Name, newName), Translations.FuelTypesList.EditConfirmationTitle)) return;

            fuelType.Name = newName;
            if (_genericRepo.Update(fuelType))
            {
                _view.ChangesAccured = System.Windows.Forms.DialogResult.Yes;
                _view.ShowMessage(Translations.FuelTypesList.EditSuccess);
                _fuelTypes[index] = fuelType;
                _view.LoadFuelTypesToGrid(_fuelTypes);
            }
            else
                _view.ShowMessage(Translations.FuelTypesList.EditFailed);
        }

        private void DeleteType(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(PermissionTabs.Contractors, PermissionType.AllowEdit)) return;

            var fuelType = _fuelTypes.FirstOrDefault(x => x.ID == _view.SelectedID);

            var isUsed = _genericRepo.GetSingle<ContractorsCars>($"WHERE {nameof(ContractorsCars.FuelTypeID)} = {fuelType.ID}");

            if (isUsed != null)
            {
                _view.ShowMessage(string.Format(Translations.FuelTypesList.FuelTypeInUseError, fuelType.Name)); return;
            }

            var index = _fuelTypes.FindIndex(x => x.ID == _view.SelectedID);
            if (fuelType == null || index < 0) return;

            if (!_view.ConfirmAction(string.Format(Translations.FuelTypesList.DeleteConfirmationBody, fuelType.Name), Translations.FuelTypesList.DeleteConfirmationTitle)) return;

            if (_genericRepo.Delete(fuelType))
            {
                _view.ChangesAccured = System.Windows.Forms.DialogResult.Yes;
                _view.ShowMessage(string.Format(Translations.FuelTypesList.DeleteSuccess, fuelType.Name));
                _fuelTypes.Remove(fuelType);
                _view.LoadFuelTypesToGrid(_fuelTypes);
            }
            else
                _view.ShowMessage(string.Format(Translations.FuelTypesList.DeleteFailed, fuelType.Name));
        }

        private void CloseForm(object sender, EventArgs e) => _view.CloseForm();
    }
}