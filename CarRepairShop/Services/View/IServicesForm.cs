using System;

namespace CarRepairShop.Services.View
{
    public interface IServicesForm
    {
        event EventHandler FormIsLoaded;
        event EventHandler FormIsClosing;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;
        string ServiceName { get; set; }
        float ServiceCost { get; set; }
        float ServiceDuration { get; set; }
        int ServiceWarrantyMonths { get; set; }
        string FormTitle { get; set; }
        void ShowMessage(string message);
        void CloseForm();
    }
}
