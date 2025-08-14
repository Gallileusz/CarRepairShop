namespace CarRepairShop.Texts
{
    public static class SharedTexts
    {
        // Home tab

        public static string HomeTabAcknowledgements => SharedResources.texts.HomeTabAcknowledgements;
        public static string HomeTabAboutThisProject => SharedResources.texts.HomeTabAboutThisProject;
        public static string HomeTabSources => SharedResources.texts.HomeTabSources;
        public static string HomeTabChangelogLoadFailed => SharedResources.texts.HomeTabChangelogLoadFailed;
        public static string HomeTabGitHubLoadFailed => SharedResources.texts.HomeTabGitHubLoadFailed;

        // Main Form

        public static string MainFormMissingPermissionsMessage => SharedResources.texts.MainForm_MissingPermissionsToOpenTab;
        public static string MainFormServices => SharedResources.texts.MainForm_Services;
        public static string MainFormContractors => SharedResources.texts.MainForm_Contractors;
        public static string MainFormCRM => SharedResources.texts.MainForm_CRM;
        public static string MainFormWarehouse => SharedResources.texts.MainForm_Warehouse;
        public static string MainFormUsers => SharedResources.texts.MainForm_Users;

        // Users tab

        public static string UsersTabAskToDeleteUserBody => SharedResources.texts.UsersTab_AskToDeleteBody;
        public static string UsersTabAskToDeleteUserTitle => SharedResources.texts.UsersTab_AskToDeleteHeader;
        public static string PermissionAssignementFailed => SharedResources.texts.UsersTab_CouldntAddPermissions;
        public static string UserDataCannotBeEmpty => SharedResources.texts.UsersTab_FirstNameAndSurnameCannotBeEmpty;
        public static string PermissionsToEditUsersMissing => SharedResources.texts.UsersTab_MissingPermissions;
        public static string SelectUserToEdit => SharedResources.texts.UsersTab_PleaseSelectPersonToEdit;
        public static string SelectUserToDelete => SharedResources.texts.UsersTab_PleaseSelectPersonToDelete;
        public static string InsertingUserFailed => SharedResources.texts.UsersTab_UserAddingError;
        public static string DeletingUserFailed => SharedResources.texts.UsersTab_UserDeleteError;
        public static string EditingUserFailed => SharedResources.texts.UsersTab_UserEditError;
        public static string UserExists => SharedResources.texts.UsersTab_UserExists;
        public static string UserHasBeenAdded => SharedResources.texts.UsersTab_UserHasBeenAdded;
        public static string UserHasBeenDeleted => SharedResources.texts.UsersTab_UserHasBeenDeleted;
        public static string UserHasBeenEdited => SharedResources.texts.UsersTab_UserHasBeenEdited;
        public static string PermissionFormTitle => SharedResources.texts.UsersTab_UsersPermissions;
    }
}
