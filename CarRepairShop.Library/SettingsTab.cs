using Translations = CarRepairShop.Texts.SharedTexts;

namespace CarRepairShop.Library
{
    public class SettingsTab
    {
        public string SelectLanguage => Translations.SettingsTab_SelectLanguage;
        public string LanguageChangeConfirmationBody => Translations.SettingsTab_LanguageChangeConfirmationBody;
        public string LanguageChangeConfirmationTitle => Translations.SettingsTab_LanguageChangeConfirmationTitle;
        public string ProvideNewPassword => Translations.SettingsTab_ProvideNewPassword;
        public string PasswordChangeConfirmationBody => Translations.SettingsTab_PasswordChangeConfirmationBody;
        public string PasswordChangeConfirmationTitle => Translations.SettingsTab_PasswordChangeConfirmationTitle;
        public string PasswordChangeSuccess => Translations.SettingsTab_PasswordChangeSuccess;
        public string PasswordChangeError => Translations.SettingsTab_PasswordChangeError;
        public string EmptyPasswordError => Translations.SettingsTab_PasswordCannotBeEmpty;
        public string TooShortPasswordError => Translations.SettingsTab_ProvidedPasswordIsTooShort;
        public string ProvidedTheSamePasswordError => Translations.SettingsTab_ProvidedCurrentPasswordOnPasswordChange;
    }
}
