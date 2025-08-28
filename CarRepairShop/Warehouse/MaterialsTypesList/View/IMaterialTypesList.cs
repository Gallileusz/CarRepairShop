using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.Warehouse.MaterialsTypesList.View
{
    public interface IMaterialTypesList
    {
        event EventHandler FormLoaded;
        event EventHandler AddMaterialTypeButtonClicked;
        event EventHandler EditMaterialTypeButtonClicked;
        event EventHandler DeleteMaterialTypeButtonClicked;
        event EventHandler CloseButtonClicked;
        event EventHandler FormIsClosing;
        void LoadMaterialTypesToGrid(List<Domain.Entities.MaterialTypes> materialTypes);
        int SelectedID { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void CloseForm();
        void SetButtonsAccessability(bool hasEditPermissions);
        string ShowInputDialog(string title, string value);
        DialogResult ChangesAccured { get; set; }
    }
}
