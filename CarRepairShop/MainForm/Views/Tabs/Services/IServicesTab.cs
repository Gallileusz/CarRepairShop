using System;
using System.Collections.Generic;

namespace CarRepairShop.MainForm.Views.Tabs.Services
{
    public interface IServicesTab
    {
        event EventHandler FormIsLoaded;
        event EventHandler DebounceTimerElapsed;
        event EventHandler FilterChanged;

        event EventHandler AddServiceButtonClicked;
        event EventHandler EditServiceButtonClicked;
        event EventHandler DeleteServiceButtonClicked;

        event EventHandler ServiceStatusCheckboxClicked;

        void LoadServicesToGrid(List<Domain.Entities.Services> services);
        bool AllStatusesRadioButtonStatus { get; }
        bool ActiveServicesRadioButtonStatus { get; }
        bool InactiveServicesRadioButtonStatus { get; }
        int SelectedServiceID { get; }
        string SearchedServiceName { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void UnableButtonsIfUserDoesntHavePermissions(bool hasEditPermissions);
    }
}
