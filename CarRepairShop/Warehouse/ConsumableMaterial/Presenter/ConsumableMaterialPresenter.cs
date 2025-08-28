using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using CarRepairShop.Warehouse.ConsumableMaterial.View;
using System;
using System.Collections.Generic;
using System.Linq;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Warehouse.ConsumableMaterial.Presenter
{
    public class ConsumableMaterialPresenter
    {
        private IConsumableMaterial _view;
        private GenericRepository _genericRepo;
        private List<MaterialTypes> _materialTypes;
        private bool _isConfirmed = false;
        private ConsumableMaterials _consumableMaterial;

        public ConsumableMaterialPresenter(IConsumableMaterial view, int? id)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _materialTypes = _genericRepo.GetAll<MaterialTypes>().ToList();

            if (id != null && id.HasValue)
                _consumableMaterial = _genericRepo.GetAll<ConsumableMaterials>().FirstOrDefault(x => x.ID == id);

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.FormIsClosing += Close;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
            _view.IncrementButtonClicked += IncrementValue;
            _view.ReductButtonClicked += ReductValue;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.PopulateCombobox(_materialTypes);

            if (_consumableMaterial != null)
            {
                _view.MaterialName = _consumableMaterial.Name;
                _view.MaterialTypeID = _consumableMaterial.MaterialTypeID;
                _view.QuantityValue = _consumableMaterial.Quantity;
            }
        }

        private void ReductValue(object sender, EventArgs e)
        {
            if (_view.QuantityValue > 0)
                _view.QuantityValue = _view.QuantityValue - 1;
        }

        private void IncrementValue(object sender, EventArgs e) => _view.QuantityValue++;

        private void Cancel(object sender, EventArgs e) => _view.CloseForm();

        private void Confirm(object sender, EventArgs e)
        {
            _isConfirmed = true;

            if (_consumableMaterial == null)
                _consumableMaterial = new ConsumableMaterials();

            _consumableMaterial.Name = _view.MaterialName;
            _consumableMaterial.Quantity = _view.QuantityValue;
            _consumableMaterial.MaterialTypeID = _view.MaterialTypeID;

            if (IsConsumableMaterialInvalid(_consumableMaterial)) return;

            _view.OperationConfirmed = System.Windows.Forms.DialogResult.Yes;
            _view.CloseForm();
        }

        private void Close(object sender, EventArgs e)
        {
            if (_isConfirmed == false)
                _view.OperationConfirmed = System.Windows.Forms.DialogResult.No;
        }

        private bool IsConsumableMaterialInvalid(ConsumableMaterials consumableMaterial)
        {
            if (_consumableMaterial == null) return true;

            if (_consumableMaterial.MaterialTypeID <= 0)
            {
                _view.ShowMessage(Translations.ConsumableMaterial.SelectMaterialType); return true;
            }

            if (string.IsNullOrEmpty(_consumableMaterial.Name))
            {
                _view.ShowMessage(Translations.ConsumableMaterial.ProvideMaterialName); return true;
            }

            if (consumableMaterial.Quantity <= 0)
            {
                _view.ShowMessage(Translations.ConsumableMaterial.CorrectMaterialQuantity); return true;
            }

            return false;
        }
    }
}
