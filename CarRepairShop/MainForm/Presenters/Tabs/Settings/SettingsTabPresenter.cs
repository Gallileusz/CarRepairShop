using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Settings;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.ComboboxForm.View;
using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Presenters.Tabs.Settings
{
    public class SettingsTabPresenter
    {
        private ISettingsTab _view;
        private GenericRepository _genericRepo;
        private List<Languages> _languages;

        public SettingsTabPresenter(ISettingsTab view)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _languages = _genericRepo.GetAll<Languages>().ToList();

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

            var cmbForm = new ComboboxForm(_languages, currentLanguage);
            cmbForm.Title = "Wybierz język:";
            cmbForm.ComboboxDisplayValue = nameof(Languages.Name);
            cmbForm.ComboboxValueMember = nameof(Languages.ID);
            cmbForm.ShowDialog();

            var language = cmbForm.SelectedItem as Languages;

            if (language == null) return;

            if (language.CultureCode == currentCultureCode) return;

            if (!_view.ConfirmAction("Zmiana języka spowoduje zresetowanie aplikacji!", "Zmiana języka")) return;

            Properties.Settings.Default.Language = language.CultureCode;
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void ChangeMyPassword(object sender, EventArgs e)
        {
            var currentUsersCredentials = _genericRepo.GetAll<UserCredentials>().FirstOrDefault(x => x.UserID == AppSettings.CurrentUser.Data.ID);

            var form = new SingleInputForm("Podaj nowe hasło:", string.Empty);
            form.ShowDialog();

            if (form.Value == null) return;

            if (IsPasswordInvalid(form.Value, currentUsersCredentials)) return;

            currentUsersCredentials.PasswordHash = BCrypt.Net.BCrypt.HashPassword(form.Value);

            if (!_view.ConfirmAction("Czy na pewno chcesz zmienić hasło?", "Zmiana hasła.")) return;

            if (_genericRepo.Update(currentUsersCredentials))
                _view.ShowMessage("Udało się zmienić hasło.");
            else
                _view.ShowMessage("Problem z dokonaniem zmian hasła!");
        }

        private bool IsPasswordInvalid(string password, UserCredentials currentCredentials)
        {
            if (string.IsNullOrEmpty(password))
            {
                _view.ShowMessage("Hasło nie może być puste!"); return true;
            }
            if (BCrypt.Net.BCrypt.HashPassword(password) == currentCredentials.PasswordHash)
            {
                _view.ShowMessage("Podane hasło do zmiany jest to samo co akutalne!"); return true;
            }

            return false;
        }
    }
}
