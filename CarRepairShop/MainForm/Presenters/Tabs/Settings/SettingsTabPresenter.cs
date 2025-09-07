using CarRepairShop.AppSettings;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Settings;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Presenters.Tabs.Settings
{
    public class SettingsTabPresenter
    {
        private readonly ISettingsTab _view;
        private readonly IGenericRepository _genericRepo;
        private readonly ICurrentUserService _currentUser;

        private readonly IEnumerable<Languages> _languages;

        public SettingsTabPresenter(ISettingsTab view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;

            _languages = _genericRepo.GetAll<Languages>();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.LanguageButtonClicked += ChangeLanguage;
            _view.ChangePasswordButtonClicked += ChangeMyPassword;
        }

        private void ChangeLanguage(object sender, EventArgs e)
        {
            var currentCultureCode = Thread.CurrentThread.CurrentUICulture.ToString();
            var currentLanguage = _languages.FirstOrDefault(x => x.CultureCode == currentCultureCode);

            var language = _view.ShowComboboxForm(_languages, Translations.MainView.SettingsTab.SelectLanguage, nameof(Languages.Name), nameof(Languages.ID), currentLanguage);

            if (language == null || language.CultureCode == currentCultureCode) return;

            if (!_view.ConfirmAction(Translations.MainView.SettingsTab.LanguageChangeConfirmationBody, Translations.MainView.SettingsTab.LanguageChangeConfirmationTitle)) return;

            Properties.Settings.Default.Language = language.CultureCode;
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void ChangeMyPassword(object sender, EventArgs e)
        {
            var credentials = _currentUser.Credentials;

            var newPassword = _view.ShowSingleInputForm(Translations.MainView.SettingsTab.ProvideNewPassword, string.Empty);

            if (newPassword == null || IsPasswordInvalid(newPassword)) return;

            credentials.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            if (!_view.ConfirmAction(Translations.MainView.SettingsTab.PasswordChangeConfirmationBody, Translations.MainView.SettingsTab.PasswordChangeConfirmationTitle)) return;

            if (_genericRepo.Update(credentials))
            {
                _currentUser.SetUser(_currentUser.Data, credentials);
                _view.ShowMessage(Translations.MainView.SettingsTab.PasswordChangeSuccess);
            }
            else
                _view.ShowMessage(Translations.MainView.SettingsTab.PasswordChangeError);
        }

        private bool IsPasswordInvalid(string password)
        {
            if (string.IsNullOrEmpty(password.Trim()))
            {
                _view.ShowMessage(Translations.MainView.SettingsTab.EmptyPasswordError); return true;
            }
            if (password.Length < 5)
            {
                _view.ShowMessage(Translations.MainView.SettingsTab.TooShortPasswordError); return true;
            }
            if (BCrypt.Net.BCrypt.HashPassword(password) == _currentUser.Credentials.PasswordHash)
            {
                _view.ShowMessage(Translations.MainView.SettingsTab.ProvidedTheSamePasswordError); return true;
            }

            return false;
        }
    }
}
