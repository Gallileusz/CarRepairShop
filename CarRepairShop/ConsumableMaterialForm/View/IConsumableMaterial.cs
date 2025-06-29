using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CarRepairShop.ConsumableMaterialForm.View
{
    public interface IConsumableMaterial
    {
        event EventHandler FormIsLoaded;
        event EventHandler FormIsClosing;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler IncrementButtonClicked;
        event EventHandler ReductButtonClicked;
        event EventHandler AddNewMaterialTypeButtonClicked;

        void PopulateCombobox(List<MaterialTypes> materialTypes);
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void CloseForm();
        string FormTitle { get; set; }
        int QuantityValue { get; set; }
        string MaterialName { get; set; }
        string MaterialTypeName { get; set; }
        ConsumableMaterials GetConsumableMaterial { get; }
    }
}
