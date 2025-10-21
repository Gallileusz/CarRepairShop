using CarRepairShop.Authentication.ConnectionSettings.DTO;
using CarRepairShop.Authentication.ConnectionSettings.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Authentication.ConnectionSettings.Presenter
{
    public class ConnectionSettingsPresenter
    {
        private readonly IConnectionSettingsView _view;
        private readonly IGenericRepository _genericRepo;

        private bool _productionConnection;
        private SettingsComparer _initialSettings;

        private List<Languages> _languages;

        public ConnectionSettingsPresenter(IConnectionSettingsView view, IGenericRepository genericRepo)
        {
            _view = view;
            _genericRepo = genericRepo;

            FetchData();
            SubscribeToEvents();
        }

        private void FetchData()
        {
            try
            {
                _languages = _genericRepo.GetAll<Languages>().ToList();
            }
            catch (Exception)
            {
                _languages = new List<Languages>
                {
                    new Languages { ID = 1, Name = "English", CultureCode = "en-US" },
                    new Languages { ID = 2, Name = "Polski", CultureCode = "pl-PL" }
                };
            }
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += Load;
            _view.ConnectionTypeChanged += ConnectionTypeChanged;
            _view.SaveButtonClicked += Save;
            _view.CancelButtonClicked += Cancel;
        }

        private void Load(object sender, EventArgs e)
        {
            _initialSettings = new SettingsComparer
            {
                DemoConnectionString = Properties.Settings.Default.DemoConnectionString,
                ProductionConnection = Properties.Settings.Default.ProductionConnection,
                Language = _languages.FirstOrDefault(x => x.CultureCode == Properties.Settings.Default.Language)
            };

            _view.PopulateLanguages(_languages, _languages.FirstOrDefault(x => x.CultureCode == _initialSettings.Language.CultureCode));
            _view.PopulateDemoConnectionString(_initialSettings.DemoConnectionString);
            _productionConnection = _initialSettings.ProductionConnection;

            _view.SetConnectionType(_productionConnection
                ? new ConnectionType(true, false)
                : new ConnectionType(false, true));

            _view.ChangesAccured = DialogResult.None;
        }

        private void ConnectionTypeChanged(object sender, ConnectionType e)
        {
            _view.SetConnectionType(e);
            _productionConnection = e.ProductionConnection;
        }

        private void Save(object sender, EventArgs e)
        {
            if (!_productionConnection && !IsConnectionStringFormatValid(_view.DemoConnectionString))
            {
                _view.ShowErrorMessage(Translations.ConnectionSettings.InvalidDemoConnectionString); return;
            }

            if (_initialSettings != GetCurrentSettings())
            {
                Properties.Settings.Default.ProductionConnection = _productionConnection;
                Properties.Settings.Default.DemoConnectionString = _view.DemoConnectionString;
                Properties.Settings.Default.Language = _languages.FirstOrDefault(x => x.ID == _view.SelectedLanguageID).CultureCode;

                Properties.Settings.Default.Save();
                _view.ChangesAccured = DialogResult.Yes;
            }

            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e) => _view.CloseForm();

        private bool IsConnectionStringFormatValid(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString)) return false;

            if (!connectionString.Contains("Server=") &&
                !connectionString.Contains("Data Source=") &&
                !connectionString.Contains("Database=") &&
                !connectionString.Contains("Initial Catalog=")) return false;

            return true;
        }

        private SettingsComparer GetCurrentSettings() => new SettingsComparer
        {
            DemoConnectionString = _view.DemoConnectionString,
            ProductionConnection = _productionConnection,
            Language = _languages.FirstOrDefault(x => x.ID == _view.SelectedLanguageID)
        };
    }
}
