using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.MainForm.Presenters.MainForm;
using CarRepairShop.Utilities.ControlUtilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.MainView
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler ContractorTabButtonClicked;
        public event EventHandler CRMTabButtonClicked;
        public event EventHandler ServicesTabButtonClicked;
        public event EventHandler UsersTabButtonClicked;
        public event EventHandler WarehouseTabButtonClicked;
        public event EventHandler SettingsButtonClicked;
        public event EventHandler MainFormIsLoaded;
        public event EventHandler HomeButtonClicked;

        public MainView()
        {
            InitializeComponent();
            var presenter = new MainViewPresenter(this, new CurrentUserService());
        }

        public void HighlightButton(Button clickedButton)
        {
            var buttons = ButtonUtilities.GetAllButtons(pnlNavigation);

            foreach (var button in buttons)
                button.ForeColor = Color.White;

            clickedButton.ForeColor = Color.Coral;
        }

        public void ShowTab(UserControl tab)
        {
            pnlBody.Controls.Clear();
            tab.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(tab);
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        private void MainView_Load(object sender, EventArgs e) => MainFormIsLoaded?.Invoke(sender, e);

        private void btnContractors_Click(object sender, EventArgs e) => ContractorTabButtonClicked?.Invoke(sender, e);

        private void btnCRM_Click(object sender, EventArgs e) => CRMTabButtonClicked?.Invoke(sender, e);

        private void btnServices_Click(object sender, EventArgs e) => ServicesTabButtonClicked?.Invoke(sender, e);

        private void btnWarehouse_Click(object sender, EventArgs e) => WarehouseTabButtonClicked?.Invoke(sender, e);

        private void btnUsers_Click(object sender, EventArgs e) => UsersTabButtonClicked?.Invoke(sender, e);

        private void btnSettings_Click(object sender, EventArgs e) => SettingsButtonClicked?.Invoke(sender, e);

        private void btnHome_Click(object sender, EventArgs e) => HomeButtonClicked?.Invoke(sender, e);
    }
}
