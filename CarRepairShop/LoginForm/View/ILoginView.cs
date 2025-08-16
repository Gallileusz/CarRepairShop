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
        event EventHandler ConnectionErrorPictureBoxClicked;

        bool CacheLogin { get; set; }
        string Login { get; set; }
        string Password { get; }

        void ChangeConnectionErrorIconVisibility(bool visible);
        void ShowMessage(string message);
        void SetErrorToolTip(string error);
        void CloseForm();
        void SetDialogResult(DialogResult result);
    }
}
