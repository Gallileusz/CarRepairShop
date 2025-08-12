using CarRepairShop.LoginForm.DTO;
using System;
using System.Windows.Forms;

namespace CarRepairShop.LoginForm.View
{
    public interface ILoginView
    {
        event EventHandler FormIsLoaded;
        event EventHandler LoginButtonClicked;
        event EventHandler<KeyPressEventArgs> EnterButtonClicked;
        event EventHandler QuitButtonClicked;
        bool CacheCheckboxSelected { get; set; }
        string Login { get; set; }
        void ShowMessage(string message);
        UserCredentialsInput UserCredentials { get; }
        void CloseLoginForm();
        void SetDialogResult(DialogResult result);
    }
}
