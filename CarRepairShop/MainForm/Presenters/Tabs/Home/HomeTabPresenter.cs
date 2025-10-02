using CarRepairShop.MainForm.Views.Tabs.Home;
using CarRepairShop.Utilities.ChangelogHandler;
using CarRepairShop.Utilities.WebBrowser;
using System;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Presenters.Tabs.Home
{
    public class HomeTabPresenter
    {
        private readonly IHomeTab _view;
        private readonly IWebBrowserHandler _webBrowserHandler;
        private readonly IChangelogHandler _changelogHandler;
        private const string _repoURL = "https://github.com/Gallileusz/CarRepairShop";

        public HomeTabPresenter(IHomeTab view, IWebBrowserHandler webHandler, IChangelogHandler changelogHandler)
        {
            _view = view;
            _webBrowserHandler = webHandler;
            _changelogHandler = changelogHandler;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.AboutThisProjectClicked += ShowAboutProject;
            _view.AcknowledgementsClicked += ShowAcknowledgements;
            _view.SourcesClicked += ShowSources;
            _view.GitHubClicked += OpenGitHubRepo;
            _view.ChangelogClicked += ShowChangelog;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _view.SetVersion(_changelogHandler.GetNewestVersion(_changelogHandler.LoadChangelog()).Version);
            _view.CurrentText = Library.Texts.MainView.Home.AboutThisProject;
        }

        private void ShowAboutProject(object sender, EventArgs e) => NavigationButtonClicked(sender, Library.Texts.MainView.Home.AboutThisProject);

        private void ShowAcknowledgements(object sender, EventArgs e) => NavigationButtonClicked(sender, Library.Texts.MainView.Home.Acknowledgements);

        private void ShowSources(object sender, EventArgs e) => NavigationButtonClicked(sender, Library.Texts.MainView.Home.Sources);

        private void ShowChangelog(object sender, EventArgs e) => NavigationButtonClicked(sender, _changelogHandler.GetChangelogStringBuilder()?.ToString() ?? Library.Texts.MainView.Home.ChangelogError);

        private async void OpenGitHubRepo(object sender, EventArgs e)
        {
            var success = await _webBrowserHandler.OpenURL(_repoURL);

            if (!success)
                _view.ShowMessage(Library.Texts.MainView.Home.GitHubError);
        }

        private void NavigationButtonClicked(object sender, string message)
        {
            _view.HighlightButton(sender as Button);
            _view.CurrentText = message;
        }
    }
}
