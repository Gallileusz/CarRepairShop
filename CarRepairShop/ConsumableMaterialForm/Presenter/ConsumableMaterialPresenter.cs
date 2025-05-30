using CarRepairShop.ConsumableMaterialForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.ConsumableMaterialForm.Presenter
{
    public class ConsumableMaterialPresenter
    {
        private IConsumableMaterial _view;
        private GenericRepository _genericRepo;
        private List<MaterialTypes> _materialTypes;
        private bool _isConfirmed = false;
        private ConsumableMaterials _consumableMaterial;

        public ConsumableMaterialPresenter(IConsumableMaterial view)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _materialTypes = _genericRepo.GetAll<MaterialTypes>().ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.FormIsClosing += Close;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
            _view.AddNewMaterialTypeButtonClicked += AddNewMaterialType;
            _view.IncrementButtonClicked += IncrementValue;
            _view.ReductButtonClicked += ReductValue;
        }

        private void ReductValue(object sender, EventArgs e)
        {
            if (_view.QuantityValue > 0)
                _view.QuantityValue = _view.QuantityValue - 1;
        }

        private void IncrementValue(object sender, EventArgs e) => _view.QuantityValue = _view.QuantityValue + 1;

        private void AddNewMaterialType(object sender, EventArgs e)
        {
            var form = new SingleInputForm("Podaj nazwę materiału", string.Empty);
            form.ShowDialog();

            if (form.Value == null) return;

            var name = form.Value;

            if (IsNewMaterialTypeNameInvalid(name)) return;

            var materialType = new MaterialTypes { Name = name };

            if (_genericRepo.Insert(materialType) > 0)
            {
                _materialTypes.Add(materialType);
                _view.PopulateCombobox(_materialTypes);
                _view.ShowMessage("Pomyślnie dodano nowy typ materiału.");
            }
            else
                _view.ShowMessage($"Nie udało się dodać materiału: {name}!");
        }

        private void Cancel(object sender, EventArgs e) => _view.CloseForm();

        private void Confirm(object sender, EventArgs e)
        {
            _isConfirmed = true;

            if (_consumableMaterial == null)
                _consumableMaterial = new ConsumableMaterials();

            _consumableMaterial.Name = _view.MaterialName;
            _consumableMaterial.Quantity = _view.QuantityValue;
            _consumableMaterial.MaterialTypeName = _view.MaterialTypeName;

            if (IsConsumableMaterialInvalid(_consumableMaterial)) return;

            _view.CloseForm();
        }

        private void Close(object sender, EventArgs e)
        {
            if (_isConfirmed == false)
                _consumableMaterial = null;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.PopulateCombobox(_materialTypes);

            if (_consumableMaterial != null)
            {
                _view.FormTitle = _consumableMaterial.Name;
                _view.MaterialName = _consumableMaterial.Name;
                _view.MaterialTypeName = _consumableMaterial.MaterialTypeName;
                _view.QuantityValue = _consumableMaterial.Quantity;
            }
        }

        public ConsumableMaterials GetConsumableMaterial() => _consumableMaterial;

        public void SetConsuambleMaterial(ConsumableMaterials material) => _consumableMaterial = material;

        private bool IsNewMaterialTypeNameInvalid(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                _view.ShowMessage("Nazwa nie może być pusta!"); return true;
            }
            if (_materialTypes.Any(x => x.Name == typeName))
            {
                _view.ShowMessage($"Materiał: {typeName} już istnieje!"); return true;
            }

            return false;
        }

        private bool IsConsumableMaterialInvalid(ConsumableMaterials consumableMaterial)
        {
            if (_consumableMaterial == null) return true;

            if (string.IsNullOrEmpty(_consumableMaterial.MaterialTypeName))
            {
                _view.ShowMessage("Wymagane jest wybranie typu miateriału zużywalnego!"); return true;
            }

            if (string.IsNullOrEmpty(_consumableMaterial.Name))
            {
                _view.ShowMessage("Wymagane jest podanie nazwy materiału zużywalnego!"); return true;
            }

            if (consumableMaterial.Quantity <= 0)
            {
                _view.ShowMessage("Ilość materiałów zużywalnych musi być większa od 0!"); return true;
            }

            return false;
        }
    }
}
