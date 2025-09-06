using Translations = CarRepairShop.Texts.SharedTexts;

namespace CarRepairShop.Library
{
    public class ServicesForm
    {
        public string NewServiceTitle => Translations.ServicesForm_NewServiceTitle;
        public string EditServiceTitle => Translations.ServicesForm_EditServiceTitle;
        public string PleaseProvideServiceName => Translations.ServicesForm_PleaseProvideServiceName;
        public string PleaseProvideServiceWarrantyTime => Translations.ServicesForm_PleaseProvideServiceWarrantyTime;
        public string PleaseProvideServiceDurationTime => Translations.ServicesForm_PleaseProvideServiceDurationTime;
        public string PleaseProvideServicePrice => Translations.ServicesForm_PleaseProvideServicePrice;
        public string ServiceWithThisNameExistsAlready => Translations.ServicesForm_ServiceWithThisNameExistsAlready;
    }
}
