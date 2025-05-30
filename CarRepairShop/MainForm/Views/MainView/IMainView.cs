using System;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.MainView
{
    public interface IMainView
    {
        event EventHandler ContractorTabButtonClicked;
        event EventHandler CRMTabButtonClicked;
        event EventHandler ServicesTabButtonClicked;
        event EventHandler UsersTabButtonClicked;
        event EventHandler WarehouseTabButtonClicked;
        event EventHandler SettingsButtonClicked;
        void ShowTab(UserControl contractorsTab);
        void ShowMessage(string message);
        void HighlightButton(Button clickedButton);
    }
}
