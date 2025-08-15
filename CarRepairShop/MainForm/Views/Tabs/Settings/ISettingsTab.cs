using System;

namespace CarRepairShop.MainForm.Views.Tabs.Settings
{
    public interface ISettingsTab
    {
        event EventHandler LanguageButtonClicked;
        event EventHandler ChangePasswordButtonClicked;

        bool ConfirmAction(string message, string title);
        void ShowMessage(string message);
    }
}
