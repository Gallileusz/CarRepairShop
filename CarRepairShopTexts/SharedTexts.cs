namespace CarRepairShop.Texts
{
    public static class SharedTexts
    {
        #region Tabs

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

        public static string UsersTab_UserInfoTitle => SharedResources.texts.UsersTab_UserInfoTitle;
        public static string UsersTab_AskToDeleteUserBody => SharedResources.texts.UsersTab_AskToDeleteBody;
        public static string UsersTab_AskToDeleteUserTitle => SharedResources.texts.UsersTab_AskToDeleteHeader;
        public static string UsersTab_PermissionAssignementFailed => SharedResources.texts.UsersTab_CouldntAddPermissions;
        public static string UsersTab_UserDataCannotBeEmpty => SharedResources.texts.UsersTab_FirstNameAndSurnameCannotBeEmpty;
        public static string UsersTab_UserCredentialsDataCannotBeEmpty => SharedResources.texts.UsersTab_UserCredentialsDataCannotBeEmpty;
        public static string UsersTab_LoginAlreadyInUse => SharedResources.texts.UsersTab_LoginAlreadyInUse;
        public static string UsersTab_PermissionsToEditUsersMissing => SharedResources.texts.UsersTab_MissingPermissions;
        public static string UsersTab_SelectUserToEdit => SharedResources.texts.UsersTab_PleaseSelectPersonToEdit;
        public static string UsersTab_SelectUserToDelete => SharedResources.texts.UsersTab_PleaseSelectPersonToDelete;
        public static string UsersTab_InsertingUserFailed => SharedResources.texts.UsersTab_UserAddingError;
        public static string UsersTab_DeletingUserFailed => SharedResources.texts.UsersTab_UserDeleteError;
        public static string UsersTab_EditingUserFailed => SharedResources.texts.UsersTab_UserEditError;
        public static string UsersTab_UserExists => SharedResources.texts.UsersTab_UserExists;
        public static string UsersTab_UserHasBeenAdded => SharedResources.texts.UsersTab_UserHasBeenAdded;
        public static string UsersTab_UserHasBeenDeleted => SharedResources.texts.UsersTab_UserHasBeenDeleted;
        public static string UsersTab_UserHasBeenEdited => SharedResources.texts.UsersTab_UserHasBeenEdited;
        public static string UsersTab_PermissionFormTitle => SharedResources.texts.UsersTab_UsersPermissions;
        public static string UsersTab_DatagridviewColumnName => SharedResources.texts.UsersTab_ColumnName;
        public static string UsersTab_DatagridviewColumnSurname => SharedResources.texts.UsersTab_ColumnSurname;

        // Warehouse Tab

        public static string WarehouseTab_All => SharedResources.texts.WarehouseTab_All;
        public static string WatehouseTab_AddConsuambleMaterial => SharedResources.texts.WatehouseTab_AddConsuambleMaterial;
        public static string WarehouseTab_MaterialAddedSuccessfully => SharedResources.texts.WarehouseTab_MaterialAddedSuccessfully;
        public static string WarehouseTab_InsertingMaterialError => SharedResources.texts.WarehouseTab_InsertingMaterialError;
        public static string WarehouseTab_MaterialEdit => SharedResources.texts.WarehouseTab_MaterialEdit;
        public static string WarehouseTab_MaterialUpdatedSuccessfully => SharedResources.texts.WarehouseTab_MaterialUpdatedSuccessfully;
        public static string WarehouseTab_MaterialUpdateError => SharedResources.texts.WarehouseTab_MaterialUpdateError;
        public static string WarehouseTab_DeleteMaterialBody => SharedResources.texts.WarehouseTab_DeleteMaterialBody;
        public static string WarehouseTab_DeleteMaterialHeader => SharedResources.texts.WarehouseTab_DeleteMaterialHeader;
        public static string WarehouseTab_MaterialDeletedSuccessfully => SharedResources.texts.WarehouseTab_DeletedSuccessfully;
        public static string WarehouseTab_MaterialDeleteError => SharedResources.texts.WarehouseTab_DeleteError;
        public static string WarehouseTab_DataGridViewColumnMaterialName => SharedResources.texts.WarehouseTab_DataGridViewColumnMaterialName;
        public static string WarehouseTab_DataGridViewColumnMaterialTypeName => SharedResources.texts.WarehouseTab_DataGridViewColumnMaterialTypeName;
        public static string WarehouseTab_DataGridViewColumnQuantity => SharedResources.texts.WarehouseTab_DataGridViewColumnQuantity;

        // Services Tab

        public static string ServicesTab_MissingEditPermissions => SharedResources.texts.ServicesTab_MissingEditPermissions;
        public static string ServicesTab_PleaseSelectService => SharedResources.texts.ServicesTab_PleaseSelectService;
        public static string ServicesTab_ConfirmServiceStatusChangeBody => SharedResources.texts.ServicesTab_ConfirmServiceStatusChangeBody;
        public static string ServicesTab_ConfirmServiceStatusChangeTitle => SharedResources.texts.ServicesTab_ConfirmServiceStatusChangeTitle;
        public static string ServicesTab_Active => SharedResources.texts.ServicesTab_Active;
        public static string ServicesTab_Inactive => SharedResources.texts.ServicesTab_Inactive;
        public static string ServicesTab_StatusChangeSuccess => SharedResources.texts.ServicesTab_StatusChangeSuccess;
        public static string ServicesTab_StatusChangeError => SharedResources.texts.ServicesTab_StatusChangeError;
        public static string ServicesTab_InsertSuccess => SharedResources.texts.ServicesTab_InsertSuccess;
        public static string ServicesTab_InsertError => SharedResources.texts.ServicesTab_InsertError;
        public static string ServicesTab_UpdateSuccess => SharedResources.texts.ServicesTab_UpdateSuccess;
        public static string ServicesTab_UpdateError => SharedResources.texts.ServicesTab_UpdateError;
        public static string ServicesTab_DeleteConfirmBody => SharedResources.texts.ServicesTab_DeleteConfirmBody;
        public static string ServicesTab_DeleteConfirmTitle => SharedResources.texts.ServicesTab_DeleteConfirmTitle;
        public static string ServicesTab_DeleteSuccess => SharedResources.texts.ServicesTab_DeleteSuccess;
        public static string ServicesTab_DeleteError => SharedResources.texts.ServicesTab_DeleteError;
        public static string ServicesTab_StatusHeaderText => SharedResources.texts.ServicesTab_StatusHeaderText;
        public static string ServicesTab_DurationHeaderText => SharedResources.texts.ServicesTab_DurationHeaderText;
        public static string ServicesTab_WarrantyHeaderText => SharedResources.texts.ServicesTab_WarrantyHeaderText;
        public static string ServicesTab_CostHeaderText => SharedResources.texts.ServicesTab_CostHeaderText;
        public static string ServicesTab_NameHeaderText => SharedResources.texts.ServicesTab_NameHeaderText;

        #endregion

        // Permissions Form
        public static string PermissionsForm_AskForConfirmationBody => SharedResources.texts.PermissionsForm_AskToSaveBody;
        public static string PermissionsForm_AskForConfirmationTitle => SharedResources.texts.PermissionsForm_AskToSaveTitle;
        public static string PermissionsForm_ChangesWereSuccessful => SharedResources.texts.PermissionsForm_ChangesSaved;
        public static string PermissionsForm_DatagridviewColumnPermissionTab => SharedResources.texts.PermissionsForm_DatagridviewColumnPermissionTab;
        public static string PermissionsForm_DatagridviewColumnAllowDisplay => SharedResources.texts.PermissionsForm_DatagridviewColumnAllowDisplay;
        public static string PermissionsForm_DatagridviewColumnAllowEdit => SharedResources.texts.PermissionsForm_DatagridviewColumnAllowEdit;
        public static string PermissionsForm_PermissionContractors => SharedResources.texts.PermissionsForm_PermissionContractors;
        public static string PermissionsForm_PermissionCRM => SharedResources.texts.PermissionsForm_PermissionCRM;
        public static string PermissionsForm_PermissionServices => SharedResources.texts.PermissionsForm_PermissionServices;
        public static string PermissionsForm_PermissionSettings => SharedResources.texts.PermissionsForm_PermissionSettings;
        public static string PermissionsForm_PermissionStatistics => SharedResources.texts.PermissionsForm_PermissionStatistics;
        public static string PermissionsForm_PermissionUsers => SharedResources.texts.PermissionsForm_PermissionUsers;
        public static string PermissionsForm_PermissionWarehouse => SharedResources.texts.PermissionsForm_PermissionWarehouse;

        // Login Form

        public static string LoginForm_LoggedOutFromAzureService => SharedResources.texts.LoginForm_LoggedOutFromAzureService;
        public static string LoginForm_DatabaseNeedsToRestart => SharedResources.texts.LoginForm_DatabaseNeedsToRestart;
        public static string LoginForm_ProvideLoginAndPassword => SharedResources.texts.LoginForm_ProvideLoginAndPassword;
        public static string LoginForm_InvalidCredentials => SharedResources.texts.LoginForm_InvalidCredentials;
        public static string LoginForm_FollowingErrorsOccurred => SharedResources.texts.LoginForm_FollowingErrorsOccurred;

        // ConsumableMaterial Form

        public static string ConsumableMaterial_ProvideNewMaterialsName => SharedResources.texts.ConsumableMaterial_ProvideNewMaterialsName;
        public static string ConsumableMaterial_MaterialInsertSuccess => SharedResources.texts.ConsumableMaterial_MaterialInsertSuccess;
        public static string ConsumableMaterial_MaterialInsertError => SharedResources.texts.ConsumableMaterial_MaterialInsertError;
        public static string ConsuambleMaterial_NameCannotBeEmpty => SharedResources.texts.ConsuambleMaterial_NameCannotBeEmpty;
        public static string ConsumableMaterial_SelectMaterialType => SharedResources.texts.ConsumableMaterial_SelectMaterialType;
        public static string ConsumableMaterial_ProvideMaterialName => SharedResources.texts.ConsumableMaterial_ProvideMaterialName;
        public static string ConsumableMaterial_CorrectMaterialQuantity => SharedResources.texts.ConsumableMaterial_CorrectMaterialQuantity;
        public static string ConsumableMaterial_MaterialExistsAlready => SharedResources.texts.ConsumableMaterial_MaterialExistsAlready;

        // MaterialsTypesList Form

        public static string MaterialsTypesList_AddNewMaterialType => SharedResources.texts.MaterialsTypesList_AddNewMaterialType;
        public static string MaterialsTypesList_InsertSuccess => SharedResources.texts.MaterialsTypesList_InsertSuccess;
        public static string MaterialsTypesList_InsertError => SharedResources.texts.MaterialsTypesList_InsertError;
        public static string MaterialsTypesList_EditMaterial => SharedResources.texts.MaterialsTypesList_EditMaterial;
        public static string MaterialsTypesList_EditMaterialConfirmationBody => SharedResources.texts.MaterialsTypesList_EditMaterialConfirmationBody;
        public static string MaterialsTypesList_EditMaterialConfirmationTitle => SharedResources.texts.MaterialsTypesList_EditMaterialConfirmationTitle;
        public static string MaterialsTypesList_EditSuccess => SharedResources.texts.MaterialsTypesList_EditSuccess;
        public static string MaterialsTypesList_EditError => SharedResources.texts.MaterialsTypesList_EditError;
        public static string MaterialsTypesList_DeleteConfirmationBody => SharedResources.texts.MaterialsTypesList_DeleteConfirmationBody;
        public static string MaterialsTypesList_DeleteConfirmationTitle => SharedResources.texts.MaterialsTypesList_DeleteConfirmationTitle;
        public static string MaterialsTypesList_DeleteSuccess => SharedResources.texts.MaterialsTypesList_DeleteSuccess;
        public static string MaterialsTypesList_DeleteError => SharedResources.texts.MaterialsTypesList_DeleteError;

        // Services Form

        public static string ServicesForm_NewServiceTitle => SharedResources.texts.ServicesForm_NewServiceTitle;
        public static string ServicesForm_EditServiceTitle => SharedResources.texts.ServicesForm_EditServiceTitle;
        public static string ServicesForm_PleaseProvideServiceName => SharedResources.texts.ServicesForm_PleaseProvideServiceName;
        public static string ServicesForm_PleaseProvideServiceWarrantyTime => SharedResources.texts.ServicesForm_PleaseProvideServiceWarrantyTime;
        public static string ServicesForm_PleaseProvideServiceDurationTime => SharedResources.texts.ServicesForm_PleaseProvideServiceDurationTime;
        public static string ServicesForm_PleaseProvideServicePrice => SharedResources.texts.ServicesForm_PleaseProvideServicePrice;
        public static string ServicesForm_ServiceWithThisNameExistsAlready => SharedResources.texts.ServicesForm_ServiceWithThisNameExistsAlready;
    }
}
