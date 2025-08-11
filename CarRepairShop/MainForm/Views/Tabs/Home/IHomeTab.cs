using System;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Home
{
    public interface IHomeTab
    {
        event EventHandler FormIsLoaded;
        event EventHandler AboutThisProjectClicked;
        event EventHandler AcknowledgementsClicked;
        event EventHandler SourcesClicked;
        event EventHandler GitHubClicked;
        event EventHandler ChangelogClicked;

        void ShowMessage(string message);
        string CurrentText { get; set; }
        void SetVersion(string version);
        void HighlightButton(Button clickedButton);
    }
}
