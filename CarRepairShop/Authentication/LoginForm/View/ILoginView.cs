using System;
using System.Windows.Forms;

namespace CarRepairShop.Authentication.LoginForm.View
{
    public interface ILoginView
    {
        event EventHandler FormIsLoaded;
        event EventHandler LoginButtonClicked;
        event EventHandler<KeyPressEventArgs> EnterButtonClicked;
        event EventHandler QuitButtonClicked;
        event EventHandler ConnectionErrorPictureBoxClicked;
        event EventHandler SettingsClicked;
        bool CacheLogin { get; set; }
        string Login { get; set; }
        string Password { get; set; }

        void ChangeLoginButtonAccessibility(bool accessible);
        void ChangeConnectionErrorIconVisibility(bool visible);
        void ShowMessage(string message);
        void SetErrorToolTip(string error);
        void CloseForm();
        void SetDialogResult(DialogResult result);
        DialogResult OpenConnectionSettingsForm();
    }
}
