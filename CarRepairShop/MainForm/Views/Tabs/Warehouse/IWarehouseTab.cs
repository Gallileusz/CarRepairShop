using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CarRepairShop.MainForm.Views.Tabs.Warehouse
{
    public interface IWarehouseTab
    {
        event EventHandler FormLoaded;
        event EventHandler AddMaterialButtonClicked;
        event EventHandler EditMaterialButtonClicked;
        event EventHandler DeleteMaterialButtonClicked;
        event EventHandler SearchTextChanged;
        event EventHandler DebounceTimerElapsed;
        event EventHandler SelectedMaterialTypeChanged;
        void LoadMaterialsToGrid(List<Domain.Entities.ConsumableMaterials> materials);
        void LoadMaterialTypesToCombobox(List<Domain.Entities.MaterialTypes> materialTypes);
        int SelectedConsumableMaterialID { get; }
        string SearchedName { get; }
        MaterialTypes SearchedMaterialType { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void UnableButtonsIfNoPermissions();
    }
}
