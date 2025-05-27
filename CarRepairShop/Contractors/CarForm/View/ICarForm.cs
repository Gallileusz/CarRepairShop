using System;
using System.Collections.Generic;
using CarRepairShop.Domain.Entities;

namespace CarRepairShop.Contractors.CarForm.View
{
    public interface ICarForm
    {
        event EventHandler FormIsLoaded;
        event EventHandler FormIsClosing;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler AddFuelTypeButtonClicked;

        string FormTitle { get; set; }
        ContractorsCars Car { get; set; }
        void PopulateFuelTypesCombobox(List<FuelTypes> fuelTypes);
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void CloseForm();
    }
}
