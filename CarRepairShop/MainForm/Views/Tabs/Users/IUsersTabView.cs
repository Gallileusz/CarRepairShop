using System;
using System.Collections.Generic;

namespace CarRepairShop.MainForm.Views.Tabs.Users
{
    public interface IUsersTabView
    {
        event EventHandler FormLoaded;
        event EventHandler AddUserButtonClicked;
        event EventHandler PermissionButtonClicked;
        event EventHandler EditUserButtonClicked;
        event EventHandler DeleteUserButtonClicked;
        event EventHandler SearchNameChanged;
        event EventHandler SearchSurameChanged;
        event EventHandler DebounceTimerElapsed;
        void LoadUsersToGrid(List<Domain.Entities.Users> users);
        int SelectedUserID { get; }
        string SearchedName { get; }
        string SearchedSurname { get; }
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void UnableButtonsIfNoPermissions();
    }
}
