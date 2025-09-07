using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CarRepairShop.MainForm.Views.Tabs.Settings
{
    public interface ISettingsTab
    {
        event EventHandler LanguageButtonClicked;
        event EventHandler ChangePasswordButtonClicked;

        bool ConfirmAction(string message, string title);
        void ShowMessage(string message);

#nullable enable
        string? ShowSingleInputForm(string title, string valueOnLoad);

#nullable enable
        Languages? ShowComboboxForm(IEnumerable<object> itemsSource, string title, string displayMember, string valueMember, object selectedItem);
    }
}
