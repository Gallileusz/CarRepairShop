using System;
using System.Drawing;
using System.Windows.Forms;
using CarRepairShop.MainForm.Presenters.MainForm;
using CarRepairShop.Utilities.ControlUtilities;

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

        public void HighlightButton(Button clickedButton)
        {
            var buttons = ButtonUtilities.GetAllButtons(pnlNavigation);

            foreach (var button in buttons)
                button.ForeColor = Color.White;

            clickedButton.ForeColor = Color.Coral;
        }

        public void ShowTab(UserControl contractorsTab)
        {
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(contractorsTab);
            contractorsTab.Dock = DockStyle.Fill;
        }

        private void btnContractors_Click(object sender, EventArgs e)
        {
            ContractorTabButtonClicked?.Invoke(sender, e);
            HighlightButton(sender as Button);
        }
        private void btnCRM_Click(object sender, EventArgs e)
        {
            CRMTabButtonClicked?.Invoke(sender, e);
            HighlightButton(sender as Button);
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            ServicesTabButtonClicked?.Invoke(sender, e);
            HighlightButton(sender as Button);
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseTabButtonClicked?.Invoke(sender, e);
            HighlightButton(sender as Button);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersTabButtonClicked?.Invoke(sender, e);
            HighlightButton(sender as Button);
        }
    }
}
