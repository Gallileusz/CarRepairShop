using CarRepairShop.Contractors.CarForm.DTO;
using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.CarForm.View
{
    public interface ICarForm
    {
        event EventHandler FormIsLoaded;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;

        string FormTitle { get; set; }
        CarFormResult CarFormResult { get; set; }
        DialogResult OperationConfirmed { get; set; }
        void PopulateFuelTypesCombobox(List<FuelTypes> fuelTypes);
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void CloseForm();
    }
}
