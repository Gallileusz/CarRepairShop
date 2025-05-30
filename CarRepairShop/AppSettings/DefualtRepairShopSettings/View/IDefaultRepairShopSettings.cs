using System;

namespace CarRepairShop.AppSettings.DefualtRepairShopSettings.View
{
    public interface IDefaultRepairShopSettings
    {
        event EventHandler FormIsClosing;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;
        string NewPassword { get; set; }
        string NewPasswordSecondField { get; set; }
        void CloseForm();
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
    }
}
