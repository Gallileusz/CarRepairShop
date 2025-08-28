using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.Warehouse;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Warehouse
{
    public interface IWarehouseTab
    {
        event EventHandler FormLoaded;
        event EventHandler AddMaterialButtonClicked;
        event EventHandler EditMaterialButtonClicked;
        event EventHandler DeleteMaterialButtonClicked;
        event EventHandler ConsumableMaterialsTypesButtonClicked;
        event EventHandler SearchTextChanged;
        event EventHandler DebounceElapsed;
        event EventHandler SelectedMaterialTypeChanged;
        void LoadMaterialsToGrid(List<ConsumableMaterialVM> materials);
        void LoadMaterialTypesToCombobox(List<MaterialTypes> materialTypes);
        int SelectedID { get; }
        string SearchedName { get; }
        int SearchedMaterialTypeID { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void SetButtonsAccesability(bool hasEditPermissions);
        void StopDebounce();
        void StartDebounce();
        DialogResult ShowMaterialTypesForm();
        ReturnedConsumableMaterial ShowConsumableMaterialsForm(int? id, string title);
    }
}
