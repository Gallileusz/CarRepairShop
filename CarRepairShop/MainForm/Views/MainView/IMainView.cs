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
        void ShowTab(UserControl contractorsTab);
        void HighlightButton(Button clickedButton);
    }
}
