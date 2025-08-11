using CarRepairShop.MainForm.Presenters.Tabs.Home;
using CarRepairShop.Utilities.ChangelogHandler;
using CarRepairShop.Utilities.ControlUtilities;
using CarRepairShop.Utilities.WebBrowser;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Home
{
    public partial class HomeTab : UserControl, IHomeTab
    {
        public event EventHandler AboutThisProjectClicked;
        public event EventHandler AcknowledgementsClicked;
        public event EventHandler SourcesClicked;
        public event EventHandler GitHubClicked;
        public event EventHandler FormIsLoaded;
        public event EventHandler ChangelogClicked;

        private readonly HomeTabPresenter _presenter;
        public HomeTab()
        {
            InitializeComponent();
            _presenter = new HomeTabPresenter(this, new WebBrowserHandler(), new ChangelogHandler());
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string CurrentText { get => txt.Text; set => txt.Text = value; }

        public void SetVersion(string version) => lblVersion.Text = version;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void HighlightButton(Button clickedButton)
        {
            var buttons = ButtonUtilities.GetAllButtons(pnlNavigation);

            foreach (var button in buttons)
                button.ForeColor = Color.White;

            clickedButton.ForeColor = Color.Coral;
        }

        private void btnAboutThisProject_Click(object sender, EventArgs e) => AboutThisProjectClicked?.Invoke(sender, e);

        private void btnAcknowledgements_Click(object sender, EventArgs e) => AcknowledgementsClicked?.Invoke(sender, e);

        private void btnSources_Click(object sender, EventArgs e) => SourcesClicked?.Invoke(sender, e);

        private void btnGitHub_Click(object sender, EventArgs e) => GitHubClicked?.Invoke(sender, e);

        private void btnChangelog_Click(object sender, EventArgs e) => ChangelogClicked?.Invoke(sender, e);

        private void HomeTab_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);
    }
}
