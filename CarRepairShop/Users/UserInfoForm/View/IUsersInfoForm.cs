using System;
using System.Windows.Forms;

namespace CarRepairShop.Users.UserInfoForm.View
{
    public interface IUsersInfoForm
    {
        event EventHandler FormLoaded;
        event FormClosingEventHandler FormIsClosing;
        event EventHandler CancelButtonClicked;
        event EventHandler ConfirmButtonClicked;
        event EventHandler<MouseEventArgs> ShowPasswordMoseClickDown;
        event EventHandler<MouseEventArgs> ShowPassworMouseClickUp;
        string FormText { get; set; }
        string UserName { get; set; }
        string UserSurname { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        bool SuperAdmin { get; set; }
        DialogResult OperationConfirmed { get; set; }
        void ChangeControlAccessibility(bool isEnabled);
        void SetSuperAdminControlAccessibility(bool userHasSuperAdminPermissions);
        void PasswordHash(char? hash);
        void CloseForm();
    }
}
