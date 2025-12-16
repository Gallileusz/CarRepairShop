using System.Windows.Forms;

namespace CarRepairShop.Users.UserInfoForm.Model
{
    public class UsersInfoModel
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool SuperAdmin { get; set; }
        public DialogResult OperationConfirmed { get; set; }

        public UsersInfoModel(string userName, string userSurname, string login, string password, bool superAdmin)
        {
            UserName = userName;
            UserSurname = userSurname;
            Login = login;
            Password = password;
            SuperAdmin = superAdmin;
        }

        public UsersInfoModel() { }
    }
}
