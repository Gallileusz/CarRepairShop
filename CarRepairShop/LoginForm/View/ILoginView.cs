using System;
using System.Windows.Forms;
using CarRepairShop.LoginForm.DTO;

namespace CarRepairShop.LoginForm.View
{
    public interface ILoginView
    {
        event EventHandler FormIsLoaded;
        event EventHandler LoginButtonClicked;
        event EventHandler QuitLabelClicked;
        bool CacheCheckboxSelected { get; set; }
        string Login { get; set; }
        void ShowMessage(string message);
        UserCredentialsInput UserCredentials { get; }
        void CloseLoginForm();
        void SetDialogResult(DialogResult result);
    }
}
