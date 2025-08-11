using CarRepairShop.Utilities.ComboboxForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.Utilities.ComboboxForm.View
{
    public partial class ComboboxForm : Form, IComboboxForm
    {
        private ComboboxFormPresenter _presenter;

        public event EventHandler FormIsLoaded;
        public event EventHandler FormIsClosing;
        public event EventHandler ButtonOkClicked;

        public ComboboxForm(IEnumerable<object> entities, object toSelect = null)
        {
            InitializeComponent();
            _presenter = new ComboboxFormPresenter(this, entities.ToList(), toSelect);
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => this.Text;
            set => this.Text = value;
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ComboboxDisplayValue { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ComboboxValueMember { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get => cmb.SelectedItem;
            set => cmb.SelectedItem = value;
        }

        private void ComboboxForm_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(sender, e);

        private void btnOK_Click(object sender, EventArgs e) => ButtonOkClicked?.Invoke(sender, e);

        public void SetComboboxDataSource(List<object> entities)
        {
            cmb.DataSource = null;
            cmb.DataSource = entities;

            cmb.DisplayMember = ComboboxDisplayValue;
            cmb.ValueMember = ComboboxValueMember;
        }

        public void CloseForm() => this.Close();

        private void ComboboxForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);
    }
}
