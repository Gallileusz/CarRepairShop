using CarRepairShop.Texts;

namespace CarRepairShop.Library
{
    public class LoginForm
    {
        public string LoggedOutFromAzureService => SharedTexts.LoginForm_LoggedOutFromAzureService;
        public string DatabaseNeedsToRestart => SharedTexts.LoginForm_DatabaseNeedsToRestart;
        public string ProvideLoginAndPassword => SharedTexts.LoginForm_ProvideLoginAndPassword;
        public string InvalidCredentials => SharedTexts.LoginForm_InvalidCredentials;
        public string FollowingErrorsOccurred => SharedTexts.LoginForm_FollowingErrorsOccurred;
    }
}
