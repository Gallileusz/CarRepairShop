using CarRepairShop.ConsumableMaterialForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Warehouse;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.MainForm.Presenters.Tabs.Warehouse
{
    public class WarehouseTabPresenter
    {
        private IWarehouseTab _view;
        private GenericRepository _genericRepo;
        private List<ConsumableMaterials> _consumableMaterials;
        private List<ConsumableMaterials> _filteredMaterials;
        private List<MaterialTypes> _materialTypes;

        public WarehouseTabPresenter(IWarehouseTab view)
        {
            _view = view;
            _genericRepo = new GenericRepository();

            _consumableMaterials = _genericRepo.GetAll<ConsumableMaterials>().ToList();
            _filteredMaterials = _consumableMaterials;

            _materialTypes = _genericRepo.GetAll<MaterialTypes>().ToList();
            if (!_materialTypes.Any(x => x.ID == 0))
                _materialTypes.Add(new MaterialTypes() { ID = 0, Name = "<-- All -->" });

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += LoadData;
            _view.AddMaterialButtonClicked += AddMaterial;
            _view.EditMaterialButtonClicked += EditMaterial;
            _view.DeleteMaterialButtonClicked += DeleteMaterial;
            _view.DebounceTimerElapsed += DebounceElapsed;
            _view.SearchTextChanged += FilterMaterials;
            _view.SelectedMaterialTypeChanged += FilterMaterials;
        }

        private void FilterMaterials(object sender, EventArgs e)
        {
            _filteredMaterials = _consumableMaterials;

            if (_view.SearchedMaterialType.ID != 0)
                _filteredMaterials = _filteredMaterials.Where(x => x.MaterialTypeName == _view.SearchedMaterialType.Name).ToList();

            string searchForMaterialName = _view.SearchedName?.Trim().ToLower() ?? string.Empty;

            if (!string.IsNullOrEmpty(searchForMaterialName))
                _filteredMaterials = _filteredMaterials.Where(m => m.Name.ToLower().Contains(searchForMaterialName)).ToList();
        }

        private void DebounceElapsed(object sender, EventArgs e) => _view.LoadMaterialsToGrid(_filteredMaterials);

        private void DeleteMaterial(object sender, EventArgs e)
        {
            if (_view.SelectedConsumableMaterialID < 0) return;
            var selectedMaterial = _consumableMaterials.FirstOrDefault(x => x.ID == _view.SelectedConsumableMaterialID);

            if (!_view.ConfirmAction($"Czy na pewno chcesz usunąć materiał:\r\n{selectedMaterial.Name} z typu: {selectedMaterial.MaterialTypeName}?\r\nAktualna ilość elementów wynosi: {selectedMaterial.Quantity}", "Czy na pewno chcesz usunąć materiał zużywalny?")) return;

            if (_genericRepo.Delete(selectedMaterial))
            {
                _consumableMaterials.Remove(selectedMaterial);
                _view.LoadMaterialsToGrid(_consumableMaterials);
                _view.ShowMessage("Usnięto materiał zużywalny.");
            }
            else
                _view.ShowMessage("Nie udało się usunąć materiału!");
        }

        private void EditMaterial(object sender, EventArgs e)
        {
            if (_view.SelectedConsumableMaterialID < 0) return;

            var selectedMaterial = _consumableMaterials.FirstOrDefault(x => x.ID == _view.SelectedConsumableMaterialID);
            var materialBeforeUpdate = selectedMaterial;

            var form = new ConsumableMaterial(selectedMaterial);
            form.ShowDialog();

            var consumableMaterial = form.GetConsumableMaterial;
            if (consumableMaterial == null) return;

            var materialIndex = _consumableMaterials.FindIndex(x => x.ID == consumableMaterial.ID);

            if (materialIndex >= 0 && _genericRepo.Update(consumableMaterial))
            {
                _view.ShowMessage("Dokonano zmian w materiale zużywalnym.");
                _consumableMaterials[materialIndex] = consumableMaterial;
                _view.LoadMaterialsToGrid(_consumableMaterials);
            }
            else
                _view.ShowMessage("Nie udało się dokonać zmian w materiale zużywalnym!");
        }

        private void AddMaterial(object sender, EventArgs e)
        {
            var form = new ConsumableMaterial(null);
            form.FormTitle = "Dodaj nowy materiał zużywalny";
            form.ShowDialog();

            var consumableMaterial = form.GetConsumableMaterial;
            if (consumableMaterial == null) return;

            if (_genericRepo.Insert(consumableMaterial) > 0)
            {
                _view.ShowMessage("Udało się dodać nowy materiał zużywalny.");
                _consumableMaterials.Add(consumableMaterial);
                _view.LoadMaterialsToGrid(_consumableMaterials);
            }
            else
                _view.ShowMessage("Nie udało się dodać nowego materiału zużywalnego!");
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.SelectedMaterialTypeChanged -= FilterMaterials;

            _view.LoadMaterialsToGrid(_consumableMaterials);
            _view.LoadMaterialTypesToCombobox(_materialTypes.OrderBy(x => x.ID).ToList());
            _view.UnableButtonsIfNoPermissions();

            _view.SelectedMaterialTypeChanged += FilterMaterials;
        }
    }
}
