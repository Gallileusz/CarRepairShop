using System;

namespace CarRepairShop.MainForm.Views.Tabs.Settings
{
    public interface ISettingsTab
    {
        event EventHandler TabIsLoaded;
        event EventHandler LanguageButtonClicked;
        event EventHandler ChangePasswordButtonClicked;
        event EventHandler ChangeDefaultPasswordButtonClicked;
        bool ConfirmAction(string message, string title);
        void ShowMessage(string message);
        void UnableDefaultSettingsButtonIfUserIsNotAdmin();
    }
}
