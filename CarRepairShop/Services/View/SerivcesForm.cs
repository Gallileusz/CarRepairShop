using CarRepairShop.Repositories;
using CarRepairShop.Services.Presenter;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace CarRepairShop.Services.View
{
    public partial class SerivcesForm : Form, IServicesForm
    {
        private readonly ServicesFormPresenter _presenter;

        public event EventHandler FormIsLoaded;
        public event EventHandler FormIsClosing;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormTitle { get => this.Text; set => this.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ServiceName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float ServiceCost
        {
            get
            {
                float.TryParse(txtCost.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out float cost); return cost;
            }
            set => txtCost.Text = value.ToString("0.00");
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float ServiceDuration
        {
            get
            {
                float.TryParse(txtTimeNeeded.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out float duration); return duration;
            }
            set => txtTimeNeeded.Text = value.ToString("0.0");
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ServiceWarrantyMonths
        {
            get
            {
                int.TryParse(txtWarrantyTime.Text, out int warranty); return warranty;
            }
            set => txtWarrantyTime.Text = value.ToString();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get => DialogResult; set => DialogResult = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Active { get => cbActive.Checked; set => cbActive.Checked = value; }

        public SerivcesForm(int? serviceID)
        {
            InitializeComponent();
            _presenter = new ServicesFormPresenter(this, new GenericRepository(), serviceID);
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void CloseForm() => this.Close();

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void SerivcesForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void SerivcesForm_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(sender, e);
    }
}
