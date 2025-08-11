using CarRepairShop.MainForm.Views.Tabs.Home;
using CarRepairShop.Utilities.ChangelogHandler;
using CarRepairShop.Utilities.WebBrowser;
using System;
using System.Linq;
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

            _view.FormIsLoaded += OnFormIsLoaded;
            _view.AboutThisProjectClicked += OnAboutThisProjectClicked;
            _view.AcknowledgementsClicked += OnAcknowledgementsClicked;
            _view.SourcesClicked += OnSourcesClicked;
            _view.GitHubClicked += OnGitHubClicked;
            _view.ChangelogClicked += OnChangelogClicked;
        }

        private void OnFormIsLoaded(object sender, EventArgs e)
        {
            _view.SetVersion(_changelogHandler.GetNewestVersion(_changelogHandler.LoadChangelog()).Version);
            _view.CurrentText = Library.Texts.MainView.HomeTab.AboutThisProject;
        }

        private void OnAboutThisProjectClicked(object sender, EventArgs e)
        {
            _view.HighlightButton(sender as Button);
            _view.CurrentText = Library.Texts.MainView.HomeTab.AboutThisProject;
        }

        private void OnAcknowledgementsClicked(object sender, EventArgs e)
        {
            _view.HighlightButton(sender as Button);
            _view.CurrentText = Library.Texts.MainView.HomeTab.Acknowledgements;
        }

        private void OnSourcesClicked(object sender, EventArgs e)
        {
            _view.HighlightButton(sender as Button);
            _view.CurrentText = Library.Texts.MainView.HomeTab.Sources;
        }

        private void OnChangelogClicked(object sender, EventArgs e)
        {
            _view.HighlightButton(sender as Button);
            var changelog = _changelogHandler.LoadChangelog();

            if (changelog != null && changelog.Any())
            {
                var sb = new System.Text.StringBuilder();
                foreach (var entry in changelog.OrderByDescending(x => DateTime.Parse(x.Date)))
                {
                    sb.AppendLine($"VERSION: {entry.Version}");
                    sb.AppendLine($"DATE: {entry.Date}");

                    sb.AppendLine("CHANGES:");
                    foreach (var change in entry.Changes)
                        sb.AppendLine($"- {change}");

                    sb.AppendLine();
                }

                _view.CurrentText = sb.ToString();
            }
            else
                _view.CurrentText = Library.Texts.MainView.HomeTab.ChangelogError;
        }

        private async void OnGitHubClicked(object sender, EventArgs e)
        {
            var success = await _webBrowserHandler.OpenURL(_repoURL);

            if (!success)
                _view.ShowMessage(Library.Texts.MainView.HomeTab.GitHubError);
        }
    }
}
