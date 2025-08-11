using System;
using System.Windows.Forms;

namespace CarRepairShop.Users.UserInfoForm.View
{
    public partial class UsersInfoForm : Form, IUsersInfoForm
    {
        public event EventHandler FormLoaded;
        public event EventHandler CancelButtonClicked;
        public event EventHandler ConfirmButtonClicked;
        public event FormClosingEventHandler FormIsClosing;

        private Presenter.UsersInfoFormPresenter _presenter;

        public UsersInfoForm(Domain.Entities.Users user)
        {
            InitializeComponent();
            _presenter = new Presenter.UsersInfoFormPresenter(this);
            _presenter.SetUser(user);
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string UserName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string UserSurname
        {
            get => txtSurname.Text;
            set => txtSurname.Text = value;
        }

        public Domain.Entities.Users GetUser() => _presenter.GetUser();

        public void CloseForm() => this.Close();

        private void btnAccept_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(this, e);

        private void UsersInfoForm_Load(object sender, EventArgs e) => FormLoaded?.Invoke(this, e);

        private void UsersInfoForm_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(this, e);
    }
}
