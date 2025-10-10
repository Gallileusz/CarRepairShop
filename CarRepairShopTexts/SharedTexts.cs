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

        // Settings Tab

        public static string SettingsTab_SelectLanguage => SharedResources.texts.SettingsTab_SelectLanguage;
        public static string SettingsTab_LanguageChangeConfirmationTitle => SharedResources.texts.SettingsTab_LanguageChangeConfirmationTitle;
        public static string SettingsTab_LanguageChangeConfirmationBody => SharedResources.texts.SettingsTab_LanguageChangeConfirmationBody;
        public static string SettingsTab_ProvideNewPassword => SharedResources.texts.SettingsTab_ProvideNewPassword;
        public static string SettingsTab_PasswordChangeConfirmationBody => SharedResources.texts.SettingsTab_PasswordChangeConfirmationBody;
        public static string SettingsTab_PasswordChangeConfirmationTitle => SharedResources.texts.SettingsTab_PasswordChangeConfirmationTitle;
        public static string SettingsTab_PasswordChangeSuccess => SharedResources.texts.SettingsTab_PasswordChangeSuccess;
        public static string SettingsTab_PasswordChangeError => SharedResources.texts.SettingsTab_PasswordChangeError;
        public static string SettingsTab_PasswordCannotBeEmpty => SharedResources.texts.SettingsTab_PasswordCannotBeEmpty;
        public static string SettingsTab_ProvidedPasswordIsTooShort => SharedResources.texts.SettingsTab_ProvidedPasswordIsTooShort;
        public static string SettingsTab_ProvidedCurrentPasswordOnPasswordChange => SharedResources.texts.SettingsTab_ProvidedCurrentPasswordOnPasswordChange;

        // CRM tab

        public static string CRMTab_TaskInsertFailed => SharedResources.texts.CRMTab_TaskInsertFailed;
        public static string CRMTab_TaskMappingsInsertFailed => SharedResources.texts.CRMTab_TaskMappingsInsertFailed;
        public static string CRMTab_TaskInsertSuccess => SharedResources.texts.CRMTab_TaskInsertSuccess;
        public static string CRMTab_ReadOnlyViewBody => SharedResources.texts.CRMTab_ReadOnlyViewBody;
        public static string CRMTab_ReadOnlyViewTitle => SharedResources.texts.CRMTab_ReadOnlyViewTitle;
        public static string CRMTab_UpdateSuccess => SharedResources.texts.CRMTab_UpdateSuccess;
        public static string CRMTab_UpdateError => SharedResources.texts.CRMTab_UpdateError;
        public static string CRMTab_MissingSuperAdminPermissions => SharedResources.texts.CRMTab_MissingSuperAdminPermissions;
        public static string CRMTab_DeleteConfirmOperationBody => SharedResources.texts.CRMTab_DeleteConfirmOperationBody;
        public static string CRMTab_DeleteConfirmOperationTitle => SharedResources.texts.CRMTab_DeleteConfirmOperationTitle;
        public static string CRMTab_DeleteTaskError => SharedResources.texts.CRMTab_DeleteTaskError;
        public static string CRMTab_DeleteTaskMappingsError => SharedResources.texts.CRMTab_DeleteTaskMappingsError;
        public static string CRMTab_DeleteSuccess => SharedResources.texts.CRMTab_DeleteSuccess;
        public static string CRMTab_ColumnMechanicFullName => SharedResources.texts.CRMTab_ColumnMechanicFullName;
        public static string CRMTab_ColumnContractorFullName => SharedResources.texts.CRMTab_ColumnContractorFullName;
        public static string CRMTab_ColumnDescription => SharedResources.texts.CRMTab_ColumnDescription;
        public static string CRMTab_ColumnVehicleData => SharedResources.texts.CRMTab_ColumnVehicleData;
        public static string CRMTab_ColumnServices => SharedResources.texts.CRMTab_ColumnServices;
        public static string CRMTab_ColumnStartDate => SharedResources.texts.CRMTab_ColumnStartDate;
        public static string CRMTab_ColumnCloseDate => SharedResources.texts.CRMTab_ColumnCloseDate;
        public static string CRMTab_ColumnPrice => SharedResources.texts.CRMTab_ColumnPrice;
        public static string CRMTab_ColumnCompleted => SharedResources.texts.CRMTab_ColumnCompleted;

        // Contractor Tab

        public static string ContractorTab_AddNewCar => SharedResources.texts.ContractorTab_AddNewCar;
        public static string ContractorTab_AddNewContractor => SharedResources.texts.ContractorTab_AddNewContractor;
        public static string ContractorTab_CarInsertError => SharedResources.texts.ContractorTab_CarInsertError;
        public static string ContractorTab_CarInsertSuccess => SharedResources.texts.ContractorTab_CarInsertSuccess;
        public static string ContractorTab_ContractorExistsError => SharedResources.texts.ContractorTab_ContractorExistsError;
        public static string ContractorTab_ContractorInsertError => SharedResources.texts.ContractorTab_ContractorInsertError;
        public static string ContractorTab_ContractorInsertSuccess => SharedResources.texts.ContractorTab_ContractorInsertSuccess;
        public static string ContractorTab_ContractorsCarExistsError => SharedResources.texts.ContractorTab_ContractorsCarExistsError;
        public static string ContractorTab_DeleteCarConfirmationBody => SharedResources.texts.ContractorTab_DeleteCarConfirmationBody;
        public static string ContractorTab_DeleteCarConfirmationTitle => SharedResources.texts.ContractorTab_DeleteCarConfirmationTitle;
        public static string ContractorTab_DeleteCarError => SharedResources.texts.ContractorTab_DeleteCarError;
        public static string ContractorTab_DeleteCarSuccess => SharedResources.texts.ContractorTab_DeleteCarSuccess;
        public static string ContractorTab_DeleteContractorConfirmationBody => SharedResources.texts.ContractorTab_DeleteContractorConfirmationBody;
        public static string ContractorTab_DeleteContractorConfirmationTitle => SharedResources.texts.ContractorTab_DeleteContractorConfirmationTitle;
        public static string ContractorTab_DeleteContractorError => SharedResources.texts.ContractorTab_DeleteContractorError;
        public static string ContractorTab_DeleteContractorsCarsError => SharedResources.texts.ContractorTab_DeleteContractorsCarsError;
        public static string ContractorTab_DeleteContractorSuccess => SharedResources.texts.ContractorTab_DeleteContractorSuccess;
        public static string ContractorTab_EditCar => SharedResources.texts.ContractorTab_EditCar;
        public static string ContractorTab_EditCarError => SharedResources.texts.ContractorTab_EditCarError;
        public static string ContractorTab_EditCarSuccess => SharedResources.texts.ContractorTab_EditCarSuccess;
        public static string ContractorTab_EditContractor => SharedResources.texts.ContractorTab_EditContractor;
        public static string ContractorTab_EditContractorError => SharedResources.texts.ContractorTab_EditContractorError;
        public static string ContractorTab_EditContractorSuccess => SharedResources.texts.ContractorTab_EditContractorSuccess;
        public static string ContractorTab_CarHasTaskMappings => SharedResources.texts.ContractorTab_CarHasTaskMappings;
        public static string ContractorsTab_BrandNameColumn => SharedResources.texts.ContractorsTab_BrandNameColumn;
        public static string ContractorsTab_ModelNameColumn => SharedResources.texts.ContractorsTab_ModelNameColumn;
        public static string ContractorsTab_LicensePlateColumn => SharedResources.texts.ContractorsTab_LicensePlateColumn;
        public static string ContractorsTab_FuelTypeColumn => SharedResources.texts.ContractorsTab_FuelTypeColumn;
        public static string ContractorsTab_MileageColumn => SharedResources.texts.ContractorsTab_MileageColumn;
        public static string ContractorsTab_ProductionYearColumn => SharedResources.texts.ContractorsTab_ProductionYearColumn;
        public static string ContractorsTab_EngineCapacityColumn => SharedResources.texts.ContractorsTab_EngineCapacityColumn;
        public static string ContractorsTab_VINColumn => SharedResources.texts.ContractorsTab_VINColumn;
        public static string ContractorsTab_ContractorNameColumn => SharedResources.texts.ContractorsTab_ContractorNameColumn;
        public static string ContractorsTab_ContractorSurnameColumn => SharedResources.texts.ContractorsTab_ContractorSurnameColumn;
        public static string ContractorsTab_EmailColumn => SharedResources.texts.ContractorsTab_EmailColumn;
        public static string ContractorsTab_PhoneNumberColumn => SharedResources.texts.ContractorsTab_PhoneNumberColumn;

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
        public static string LoginForm_ConnectionCancelled => SharedResources.texts.LoginForm_ConnectionCancelled;

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

        // CRMForm

        public static string CRMForm_ConfirmClosureBody => SharedResources.texts.CRMForm_ConfirmClosureBody;
        public static string CRMForm_ConfirmClosureTitle => SharedResources.texts.CRMForm_ConfirmClosureTitle;
        public static string CRMForm_ConfirmReOpenBody => SharedResources.texts.CRMForm_ConfirmReOpenBody;
        public static string CRMForm_ConfirmReOpenTitle => SharedResources.texts.CRMForm_ConfirmReOpenTitle;
        public static string CRMForm_Error => SharedResources.texts.CRMForm_Error;
        public static string CRMForm_Warning => SharedResources.texts.CRMForm_Warning;
        public static string CRMForm_SelectContractor => SharedResources.texts.CRMForm_SelectContractor;
        public static string CRMForm_SelectVehicle => SharedResources.texts.CRMForm_SelectVehicle;
        public static string CRMForm_SelectService => SharedResources.texts.CRMForm_SelectService;
        public static string CRMForm_EmptyComment => SharedResources.texts.CRMForm_EmptyComment;
        public static string CRMForm_Yes => SharedResources.texts.CRMForm_Yes;
        public static string CRMForm_No => SharedResources.texts.CRMForm_No;

        public static string CRMForm_QuantityColumn => SharedResources.texts.CRMForm_QuantityColumn;
        public static string CRMForm_NameColumn => SharedResources.texts.CRMForm_NameColumn;
        public static string CRMForm_PriceColumn => SharedResources.texts.CRMForm_PriceColumn;
        public static string CRMForm_BrandColumn => SharedResources.texts.CRMForm_BrandColumn;
        public static string CRMForm_ModelColumn => SharedResources.texts.CRMForm_ModelColumn;
        public static string CRMForm_MileageColumn => SharedResources.texts.CRMForm_MileageColumn;
        public static string CRMForm_LicensePlateColumn => SharedResources.texts.CRMForm_LicensePlateColumn;
        public static string CRMForm_FuelTypeColumn => SharedResources.texts.CRMForm_FuelTypeColumn;
        public static string CRMForm_EngineCapacityColumn => SharedResources.texts.CRMForm_EngineCapacityColumn;
        public static string CRMForm_ProductionYearColumn => SharedResources.texts.CRMForm_ProductionYear;

        // ContractorForm

        public static string ContractorForm_FillName => SharedResources.texts.ContractorForm_FillName;
        public static string ContractorForm_FillSurname => SharedResources.texts.ContractorForm_FillSurname;
        public static string ContractorForm_FillPhoneNumber => SharedResources.texts.ContractorForm_FillPhoneNumber;
        public static string ContractorForm_IncorrectPhoneNumber => SharedResources.texts.ContractorForm_IncorrectPhoneNumber;
        public static string ContractorForm_FillEmail => SharedResources.texts.ContractorForm_FillEmail;
        public static string ContractorForm_IncorrectEmail => SharedResources.texts.ContractorForm_IncorrectEmail;

        // CarForm

        public static string CarForm_FillBrand => SharedResources.texts.CarForm_FillBrand;
        public static string CarForm_FillModel => SharedResources.texts.CarForm_FillModel;
        public static string CarForm_FillProductionYear => SharedResources.texts.CarForm_FillProductionYear;
        public static string CarForm_FillVIN => SharedResources.texts.CarForm_FillVIN;
        public static string CarForm_FillLicensePlate => SharedResources.texts.CarForm_FillLicensePlate;
        public static string CarForm_FillEngineCapacity => SharedResources.texts.CarForm_FillEngineCapacity;
        public static string CarForm_SelectFuelType => SharedResources.texts.CarForm_SelectFuelType;
        public static string CarForm_FillMileage => SharedResources.texts.CarForm_FillMileage;

        // FuelTypesList Form

        public static string FuelTypesList_AddNewFuelType => SharedResources.texts.FuelTypesList_AddNewFuelType;
        public static string FuelTypesList_DeleteConfirmationBody => SharedResources.texts.FuelTypesList_DeleteConfirmationBody;
        public static string FuelTypesList_DeleteConfirmationTitle => SharedResources.texts.FuelTypesList_DeleteConfirmationTitle;
        public static string FuelTypesList_DeleteFailed => SharedResources.texts.FuelTypesList_DeleteFailed;
        public static string FuelTypesList_DeleteSuccess => SharedResources.texts.FuelTypesList_DeleteSuccess;
        public static string FuelTypesList_EditConfirmationBody => SharedResources.texts.FuelTypesList_EditConfirmationBody;
        public static string FuelTypesList_EditConfirmationTitle => SharedResources.texts.FuelTypesList_EditConfirmationTitle;
        public static string FuelTypesList_EditFailed => SharedResources.texts.FuelTypesList_EditFailed;
        public static string FuelTypesList_EditFuelType => SharedResources.texts.FuelTypesList_EditFuelType;
        public static string FuelTypesList_EditSuccess => SharedResources.texts.FuelTypesList_EditSuccess;
        public static string FuelTypesList_InsertFailed => SharedResources.texts.FuelTypesList_InsertFailed;
        public static string FuelTypesList_InsertSuccess => SharedResources.texts.FuelTypesList_InsertSuccess;
        public static string FuelTypesList_Name => SharedResources.texts.FuelTypesList_Name;
        public static string FuelTypesList_FuelTypeInUseError => SharedResources.texts.FuelTypesList_FuelTypeInUseError;
    }
}
