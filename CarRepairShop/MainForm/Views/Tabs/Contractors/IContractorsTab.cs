using CarRepairShop.Contractors.CarForm.DTO;
using CarRepairShop.Contractors.ContractorForm.DTO;
using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Contractors
{
    public interface IContractorsTab
    {
        event EventHandler FormIsLoaded;
        event EventHandler DebounceElapsed;
        event EventHandler FilterChanged;
        event EventHandler ContractorSelectionChanged;
        event EventHandler FuelTypesButtonClicked;

        event EventHandler AddContractorButtonClicked;
        event EventHandler EditContractorButtonClicked;
        event EventHandler DeleteContractorButtonClicked;

        event EventHandler AddCarButtonClicked;
        event EventHandler EditCarButtonClicked;
        event EventHandler DeleteCarButtonClicked;
        void LoadContractorsToGrid(List<Domain.Entities.Contractors> contractors);
        void LoadContractorsCarsToGrid(List<ContractorsCars> car);
        void ResetGridSelections();
        void SelectContractorByID(int contractorId);
        void SelectCarByID(int contractorId);
        int SelectedContractorID { get; }
        int SelectedCarID { get; }
        string SearchedContractorName { get; }
        string SearchedContractorSurname { get; }
        string SearchedCarBrandName { get; }
        string SearchedCarModelName { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void ChangeButtonAccess(bool hasPermission);
        ContractorFormResult OpenContractorForm(int? id = null, string title = "");
        CarFormResult OpenCarForm(int? id = null, string title = "");
        DialogResult OpenFuelTypesDictionary();
        void StopDebounce();
        void StartDebounce();
    }
}
