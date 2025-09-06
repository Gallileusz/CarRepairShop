using SharedTexts = CarRepairShop.Texts.SharedTexts;

namespace CarRepairShop.Library
{
    public class ServicesTab
    {
        public string MissingEditPermissions => SharedTexts.ServicesTab_MissingEditPermissions;
        public string ServiceNotSelected => SharedTexts.ServicesTab_PleaseSelectService;
        public string ConfirmServiceStatusChangeBody => SharedTexts.ServicesTab_ConfirmServiceStatusChangeBody;
        public string ConfirmServiceStatusChangeTitle => SharedTexts.ServicesTab_ConfirmServiceStatusChangeTitle;
        public string Active => SharedTexts.ServicesTab_Active;
        public string Inactive => SharedTexts.ServicesTab_Inactive;
        public string StatusChangeSuccess => SharedTexts.ServicesTab_StatusChangeSuccess;
        public string StatusChangeError => SharedTexts.ServicesTab_StatusChangeError;
        public string InsertSuccess => SharedTexts.ServicesTab_InsertSuccess;
        public string InsertError => SharedTexts.ServicesTab_InsertError;
        public string UpdateSuccess => SharedTexts.ServicesTab_UpdateSuccess;
        public string UpdateError => SharedTexts.ServicesTab_UpdateError;
        public string DeleteConfirmBody => SharedTexts.ServicesTab_DeleteConfirmBody;
        public string DeleteConfirmTitle => SharedTexts.ServicesTab_DeleteConfirmTitle;
        public string DeleteSuccess => SharedTexts.ServicesTab_DeleteSuccess;
        public string DeleteError => SharedTexts.ServicesTab_DeleteError;

        public string StatusHeaderText => SharedTexts.ServicesTab_StatusHeaderText;
        public string DurationHeaderText => SharedTexts.ServicesTab_DurationHeaderText;
        public string WarrantyHeaderText => SharedTexts.ServicesTab_WarrantyHeaderText;
        public string CostHeaderText => SharedTexts.ServicesTab_CostHeaderText;
        public string NameHeaderText => SharedTexts.ServicesTab_NameHeaderText;
    }
}
