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
        string UserName { get; set; }
        string UserSurname { get; set; }
        void CloseForm();
    }
}
