using Translations = CarRepairShop.Texts.SharedTexts;

namespace CarRepairShop.Library
{
    public class ContractorForm
    {
        public string FillNameField => Translations.ContractorForm_FillName;
        public string FillSurnameField => Translations.ContractorForm_FillSurname;
        public string FillPhoneNumberField => Translations.ContractorForm_FillPhoneNumber;
        public string IncorrectPhoneNumber => Translations.ContractorForm_IncorrectPhoneNumber;
        public string FillEmailField => Translations.ContractorForm_FillEmail;
        public string IncorrectEmail => Translations.ContractorForm_IncorrectEmail;
    }
}
