using CarRepairShop.AppSettings.DefualtRepairShopSettings.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using System;
using System.Linq;

namespace CarRepairShop.AppSettings.DefualtRepairShopSettings.Presenter
{
    public class DefaultRepairShopSettingsPresenter
    {
        private IDefaultRepairShopSettings _view;
        private GenericRepository _genericRepo;
        private bool _isConfirmed = false;

        public DefaultRepairShopSettingsPresenter(IDefaultRepairShopSettings view)
        {
            _view = view;
            _genericRepo = new GenericRepository();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsClosing += Close;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
        }

        private void Close(object sender, EventArgs e)
        {
            if (!_isConfirmed)
            {
                _view.NewPassword = null;
                _view.NewPasswordSecondField = null;
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (IsNewPasswordInvalid(_view.NewPassword, _view.NewPasswordSecondField)) return;

            if (!_view.ConfirmAction("Czy na pewno chcesz zmienić dla nowo dodanych użytkowników hasło?", "Zmiana hasła przy tworzeniu użytkownika")) return;

            _isConfirmed = true;
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e)
        {
            _isConfirmed = false;
            _view.CloseForm();
        }

        private bool IsNewPasswordInvalid(string firstField, string secondField)
        {
            if (string.IsNullOrWhiteSpace(firstField) || string.IsNullOrWhiteSpace(secondField))
            {
                _view.ShowMessage("Hasło nie może być puste!"); return true;
            }
            if (firstField != secondField)
            {
                _view.ShowMessage("Hasła muszą być takie same!"); return true;
            }
            if (firstField.Length < 8)
            {
                _view.ShowMessage("Hasło musi mieć co najmniej 8 znaków!"); return true;
            }
            if (_genericRepo.GetAll<DefaultSettings>().FirstOrDefault().PasswordHash == BCrypt.Net.BCrypt.HashPassword(firstField))
            {
                _view.ShowMessage("Nowe hasło nie może być takie samo jak aktualne!"); return true;
            }

            return false;
        }
    }
}
