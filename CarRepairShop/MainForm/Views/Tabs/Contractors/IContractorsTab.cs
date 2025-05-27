using System;
using System.Collections.Generic;
using CarRepairShop.Domain.Entities;

namespace CarRepairShop.MainForm.Views.Tabs.Contractors
{
    public interface IContractorsTab
    {
        event EventHandler FormIsLoaded;
        event EventHandler ContractorSelectionChanged;
        event EventHandler DebounceTimerElapsed;
        event EventHandler SearchNameChanged;
        event EventHandler SearchSurameChanged;
        event EventHandler SearchBrandNameChanged;
        event EventHandler SearchModelNameChanged;

        event EventHandler AddContractorButtonClicked;
        event EventHandler EditContractorButtonClicked;
        event EventHandler DeleteContractorButtonClicked;

        event EventHandler AddCarButtonClicked;
        event EventHandler EditCarButtonClicked;
        event EventHandler DeleteCarButtonClicked;
        void LoadContractorsToGrid(List<Domain.Entities.Contractors> contractors);
        void LoadContractorsCarsToGrid(List<ContractorsCars> car);
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
    }
}
