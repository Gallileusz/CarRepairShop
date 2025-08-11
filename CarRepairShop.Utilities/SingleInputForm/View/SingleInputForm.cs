using System;
using System.Windows.Forms;

namespace CarRepairShop.Utilities.SingleInputForm.View
{
    public partial class SingleInputForm : Form, ISingleInputForm
    {
        private Presenter.SingleInputFormPresenter _presenter;

        public event EventHandler FormLoaded;
        public event FormClosingEventHandler FormIsClosing;
        public event EventHandler OKButtonClicked;

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string FormTitle
        {
            get => this.Text;
            set => this.Text = value;
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string Value
        {
            get => txt.Text;
            set => txt.Text = value;
        }

        public SingleInputForm(string formTitle, string valueOnLoad = "")
        {
            InitializeComponent();
            _presenter = new Presenter.SingleInputFormPresenter(this, formTitle, valueOnLoad);
        }

        public void CloseForm() => this.Close();

        private void SingleInputForm_Load(object sender, EventArgs e) => FormLoaded?.Invoke(this, EventArgs.Empty);

        private void btnOK_Click(object sender, EventArgs e) => OKButtonClicked?.Invoke(this, EventArgs.Empty);
    }
}
