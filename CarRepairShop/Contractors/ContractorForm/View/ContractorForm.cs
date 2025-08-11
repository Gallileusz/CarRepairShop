using System;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.ContractorForm.View
{
    public partial class ContractorForm : Form, IContractorForm
    {
        private Presenter.ContractorFormPresenter _presenter;

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ContractorName { get => txtName.Text; set => txtName.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ContractorSurname { get => txtSurname.Text; set => txtSurname.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ContractorEmail { get => txtEmail.Text; set => txtEmail.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ContractorPhoneNumber { get => txtPhoneNumber.Text; set => txtPhoneNumber.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string FormTitle { get => this.Text; set => this.Text = value; }

        public event EventHandler FormIsLoaded;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler FormIsClosing;

        public ContractorForm(Domain.Entities.Contractors contractor)
        {
            InitializeComponent();
            _presenter = new Presenter.ContractorFormPresenter(this);
            _presenter.SetContractor(contractor);
        }

        public Domain.Entities.Contractors GetContractor() => _presenter.GetContractor();

        public void CloseForm() => this.Close();

        public void SetDialogResult(DialogResult result) => this.DialogResult = result;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void ContractorForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void ContractorForm_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(sender, e);
    }
}
