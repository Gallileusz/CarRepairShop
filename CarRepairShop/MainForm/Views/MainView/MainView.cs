using System;
using System.Windows.Forms;
using CarRepairShop.MainForm.Presenters.MainForm;

namespace CarRepairShop.MainForm.Views.MainView
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler ContractorTabButtonClicked;
        public event EventHandler CRMTabButtonClicked;
        public event EventHandler ServicesTabButtonClicked;
        public event EventHandler UsersTabButtonClicked;
        public event EventHandler WarehouseTabButtonClicked;

        public MainView()
        {
            InitializeComponent();
            var presenter = new MainViewPresenter(this);
        }

        public void ShowTab(UserControl contractorsTab)
        {
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(contractorsTab);
            contractorsTab.Dock = DockStyle.Fill;
        }

        private void btnContractors_Click(object sender, EventArgs e) => ContractorTabButtonClicked?.Invoke(sender, e);

        private void btnCRM_Click(object sender, EventArgs e) => CRMTabButtonClicked?.Invoke(sender, e);

        private void btnServices_Click(object sender, EventArgs e) => ServicesTabButtonClicked?.Invoke(sender, e);

        private void btnWarehouse_Click(object sender, EventArgs e) => WarehouseTabButtonClicked?.Invoke(sender, e);

        private void btnUsers_Click(object sender, EventArgs e) => UsersTabButtonClicked?.Invoke(sender, e);
    }
}
