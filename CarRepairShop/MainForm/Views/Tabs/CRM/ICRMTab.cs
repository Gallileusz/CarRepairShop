using CarRepairShop.MainForm.Models.Tabs.CRM;
using System;
using System.Collections.Generic;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    public interface ICRMTab
    {
        event EventHandler AddButtonClicked;
        event EventHandler EditButtonClicked;
        event EventHandler DeleteButtonClicked;
        event EventHandler FormIsLoaded;
        event EventHandler DebounceElapsed;
        event EventHandler FilterChanged;

        void PopulateCRMTasksGrid(List<CRM_Model> crms);
        int SelectedCRMTaskID { get; }
        DateTime FilterDateFrom { get; set; }
        DateTime FilterDateTo { get; }
        string FilterContractorFullName { get; }
        string FilterMechanicFullName { get; }
        bool FilterShowAllChecked { get; }
        bool FilterShowCompletedChecked { get; }
        bool FilterShowNotCompletedChecked { get; }

        void ChangeButtonAccess(bool enabled);
        bool ConfirmAction(string message, string title);
        void ShowMessage(string message);
        void StopDebounce();
        void StartDebounce();

    }
}
