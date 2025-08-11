using CarRepairShop.AppSettings.DefualtRepairShopSettings.Presenter;
using System;
using System.Windows.Forms;

namespace CarRepairShop.AppSettings.DefualtRepairShopSettings.View
{
    public partial class DefaultRepairShopSettings : Form, IDefaultRepairShopSettings
    {
        private DefaultRepairShopSettingsPresenter _presenter;

        public event EventHandler FormIsClosing;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string NewPassword { get => txtNewPasswordFirstField.Text; set => txtNewPasswordFirstField.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string NewPasswordSecondField { get => txtNewPasswordSecondField.Text; set => txtNewPasswordSecondField.Text = value; }

        public DefaultRepairShopSettings()
        {
            InitializeComponent();
            _presenter = new DefaultRepairShopSettingsPresenter(this);
        }

        private void DefaultRepairShopSettings_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(sender, e);

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void CloseForm() => this.Close();
    }
}
