using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.FuelTypesList.View
{
    public interface IFuelTypesList
    {
        event EventHandler FormLoaded;
        event EventHandler AddFuelTypeButtonClicked;
        event EventHandler EditFuelTypeButtonClicked;
        event EventHandler DeleteFuelTypeButtonClicked;
        event EventHandler CloseButtonClicked;
        void LoadFuelTypesToGrid(List<FuelTypes> fuelTypes);
        int SelectedID { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void CloseForm();
        void SetButtonsAccessability(bool hasEditPermissions);
        string ShowInputDialog(string title, string value);
        DialogResult ChangesAccured { get; set; }
    }
}
