using CarRepairShop.Authentication.ConnectionSettings.DTO;
using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.Authentication.ConnectionSettings.View
{
    public interface IConnectionSettingsView
    {
        event EventHandler FormLoaded;
        event EventHandler<ConnectionType> ConnectionTypeChanged;
        event EventHandler SaveButtonClicked;
        event EventHandler CancelButtonClicked;

        DialogResult ChangesAccured { get; set; }
        int SelectedLanguageID { get; }
        string DemoConnectionString { get; }

        void SetConnectionType(ConnectionType connectionType);
#nullable enable
        void PopulateDemoConnectionString(string? demoConnectionString);
        void CloseForm();
        void ShowErrorMessage(string message);
        void PopulateLanguages(List<Languages> languages, Languages currentLanguage);
    }
}
