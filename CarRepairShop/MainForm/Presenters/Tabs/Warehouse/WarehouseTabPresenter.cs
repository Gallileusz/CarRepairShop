using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.Warehouse;
using CarRepairShop.MainForm.Views.Tabs.Warehouse;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Presenters.Tabs.Warehouse
{
    public class WarehouseTabPresenter
    {
        private IWarehouseTab _view;
        private IGenericRepository _genericRepo;
        private ICurrentUserService _currentUser;

        private List<ConsumableMaterials> _consumableMaterials;
        private List<MaterialTypes> _materialTypes;

        public WarehouseTabPresenter(IWarehouseTab view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;

            _consumableMaterials = _genericRepo.GetAll<ConsumableMaterials>().ToList();

            _materialTypes = _genericRepo.GetAll<MaterialTypes>().ToList();
            if (!_materialTypes.Any(x => x.ID == 0))
                _materialTypes.Add(new MaterialTypes() { ID = 0, Name = $"<-- {Translations.MainView.Warehouse.All} -->" });

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += LoadData;
            _view.AddMaterialButtonClicked += AddMaterial;
            _view.EditMaterialButtonClicked += EditMaterial;
            _view.DeleteMaterialButtonClicked += DeleteMaterial;
            _view.DebounceElapsed += DebounceElapsed;
            _view.SearchTextChanged += StartDebounce;
            _view.SelectedMaterialTypeChanged += StartDebounce;
            _view.ConsumableMaterialsTypesButtonClicked += ShowConsumableMaterialTypes;
        }

        void UnsubsribeToFilterEvents()
        {
            _view.SearchTextChanged -= StartDebounce;
            _view.SelectedMaterialTypeChanged -= StartDebounce;
        }

        void SubscribeToFilterEvents()
        {
            _view.SearchTextChanged += StartDebounce;
            _view.SelectedMaterialTypeChanged += StartDebounce;
        }

        private void LoadData(object sender, EventArgs e)
        {
            UnsubsribeToFilterEvents();

            _view.StopDebounce();
            _view.LoadMaterialsToGrid(GetModels());
            _view.LoadMaterialTypesToCombobox(_materialTypes.OrderBy(x => x.ID).ToList());
            _view.SetButtonsAccesability(_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.PermissionType.AllowEdit));

            SubscribeToFilterEvents();
        }

        private void AddMaterial(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var form = _view.ShowConsumableMaterialsForm(null, Translations.MainView.Warehouse.AddNewMaterial);

            if (form.OperationConfirmed != DialogResult.Yes) return;

            if (form.ConsumableMaterial == null) return;

            if (_genericRepo.Insert(form.ConsumableMaterial) > 0)
            {
                UpdateMaterialTypesListIfNeeded(form.ConsumableMaterial);

                _view.ShowMessage(Translations.MainView.Warehouse.InsertedSuccessfully);
                _consumableMaterials.Add(form.ConsumableMaterial);
                _view.LoadMaterialsToGrid(GetModels());
            }
            else
                _view.ShowMessage(Translations.MainView.Warehouse.InsertError);
        }

        private void EditMaterial(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.PermissionType.AllowEdit)) return;

            if (_view.SelectedID < 0) return;

            var selectedMaterial = _consumableMaterials.FirstOrDefault(x => x.ID == _view.SelectedID);

            var form = _view.ShowConsumableMaterialsForm(_view.SelectedID, string.Format(Translations.MainView.Warehouse.EditMaterial, selectedMaterial.Name));

            if (form.OperationConfirmed != DialogResult.Yes) return;

            if (form.ConsumableMaterial == null) return;

            form.ConsumableMaterial.ID = selectedMaterial.ID;

            var materialIndex = _consumableMaterials.FindIndex(x => x.ID == form.ConsumableMaterial.ID);

            if (materialIndex >= 0 && _genericRepo.Update(form.ConsumableMaterial))
            {
                UpdateMaterialTypesListIfNeeded(form.ConsumableMaterial);
                _view.ShowMessage(Translations.MainView.Warehouse.UpdatedSuccessfully);
                _consumableMaterials[materialIndex] = form.ConsumableMaterial;
                _view.LoadMaterialsToGrid(GetModels());
            }
            else
                _view.ShowMessage(Translations.MainView.Warehouse.UpdateError);
        }

        private void DeleteMaterial(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.PermissionType.AllowEdit)) return;

            if (_view.SelectedID < 0) return;
            var selectedMaterial = _consumableMaterials.FirstOrDefault(x => x.ID == _view.SelectedID);

            if (!_view.ConfirmAction($"{Translations.MainView.Warehouse.DeleteBody}\r\n{selectedMaterial.Name}?", Translations.MainView.Warehouse.DeleteHeader)) return;

            if (_genericRepo.Delete(selectedMaterial))
            {
                _consumableMaterials.Remove(selectedMaterial);
                _view.LoadMaterialsToGrid(GetModels());
                _view.ShowMessage(Translations.MainView.Warehouse.DeletedSuccessfully);
            }
            else
                _view.ShowMessage(Translations.MainView.Warehouse.DeleteError);
        }

        private List<ConsumableMaterialVM> GetModels()
        {
            var filteredMaterials = _consumableMaterials;

            if (_view.SearchedMaterialTypeID != 0)
                filteredMaterials = filteredMaterials.Where(x => x.MaterialTypeID == _view.SearchedMaterialTypeID).ToList();

            string searchForMaterialName = _view.SearchedName?.Trim().ToLower() ?? string.Empty;

            if (!string.IsNullOrEmpty(searchForMaterialName))
                filteredMaterials = filteredMaterials.Where(m => m.Name.ToLower().Contains(searchForMaterialName)).ToList();

            return filteredMaterials.Select(x => new ConsumableMaterialVM
            {
                ID = x.ID,
                Name = x.Name,
                Quantity = x.Quantity,
                MaterialTypeName = _materialTypes.FirstOrDefault(y => y.ID == x.MaterialTypeID).Name
            }).ToList();
        }

        private void ShowConsumableMaterialTypes(object sender, EventArgs e)
        {
            var changesAccured = _view.ShowMaterialTypesForm();

            if (changesAccured != DialogResult.Yes) return;

            _materialTypes = _genericRepo.GetAll<MaterialTypes>().OrderBy(x => x.ID).ToList();
            _view.LoadMaterialTypesToCombobox(_materialTypes);
        }

        private void UpdateMaterialTypesListIfNeeded(ConsumableMaterials material)
        {
            if (_materialTypes.Any(x => x.ID == material.ID)) return;

            _materialTypes = _genericRepo.GetAll<MaterialTypes>().ToList();
            if (!_materialTypes.Any(x => x.ID == 0))
                _materialTypes.Add(new MaterialTypes() { ID = 0, Name = $"<-- {Translations.MainView.Warehouse.All} -->" });

            _materialTypes = _materialTypes.OrderBy(x => x.ID).ToList();

            UnsubsribeToFilterEvents();

            _view.LoadMaterialTypesToCombobox(_materialTypes);

            SubscribeToFilterEvents();
        }

        private void StartDebounce(object sender, EventArgs e) => _view.StartDebounce();

        private void DebounceElapsed(object sender, EventArgs e)
        {
            _view.StopDebounce();
            _view.LoadMaterialsToGrid(GetModels());
        }
    }
}
