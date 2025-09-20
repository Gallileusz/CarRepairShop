using CarRepairShop.Contractors.ContractorForm.DTO;
using CarRepairShop.Repositories;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.ContractorForm.View
{
    public partial class ContractorForm : Form, IContractorForm
    {
        public event EventHandler FormIsLoaded;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;

        private readonly Presenter.ContractorFormPresenter _presenter;

        public ContractorForm(int? id)
        {
            InitializeComponent();
            _presenter = new Presenter.ContractorFormPresenter(this, new GenericRepository(), id);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ContractorName { get => txtName.Text; set => txtName.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ContractorSurname { get => txtSurname.Text; set => txtSurname.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ContractorEmail { get => txtEmail.Text; set => txtEmail.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ContractorPhoneNumber { get => txtPhoneNumber.Text; set => txtPhoneNumber.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormTitle { get => this.Text; set => this.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get => this.DialogResult; set => DialogResult = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ContractorFormResult ContractorFormResult
        {
            get => new ContractorFormResult()
            {
                Contractor = new Domain.Entities.Contractors
                {
                    Email = txtEmail.Text,
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                },
                OperationConfirmed = this.OperationConfirmed
            };
        }

        public void CloseForm() => this.Close();

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void ContractorForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);
    }
}
