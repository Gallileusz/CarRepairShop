using CarRepairShop.Users.PermissionsForm.Model;
using System;
using System.Collections.Generic;

namespace CarRepairShop.Users.PermissionsForm.View
{
    public interface IPermissionsView
    {
        event EventHandler ConfirmClicked;
        event EventHandler CancelClicked;
        event EventHandler FormLoaded;

        string FormTitle { get; set; }
        void PopulateDatagridView(List<PermissionModel> permissionModels);
        List<PermissionModel> GetSelectedPermissions { get; }
        void CloseForm();
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
    }
}
