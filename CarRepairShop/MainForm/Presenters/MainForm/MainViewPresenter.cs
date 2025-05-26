using System;
using CarRepairShop.MainForm.Views.MainView;
using CarRepairShop.MainForm.Views.Tabs.ContractorsTab;
using CarRepairShop.MainForm.Views.Tabs.CRM;

namespace CarRepairShop.MainForm.Presenters.MainForm
{
    public class MainViewPresenter
    {
        private readonly IMainView _view;

        public MainViewPresenter(IMainView view)
        {
            _view = view;
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _view.ContractorTabButtonClicked += ShowContractorsTab;
            _view.CRMTabButtonClicked += ShowCRMTab;
            _view.WarehouseTabButtonClicked += ShowWarehouseTab;
            _view.UsersTabButtonClicked += ShowUsersTab;
            _view.ServicesTabButtonClicked += ShowServicesTab;
        }

        private void ShowServicesTab(object sender, EventArgs e) => _view.ShowTab(new ServicesTab());

        private void ShowUsersTab(object sender, EventArgs e) => _view.ShowTab(new UsersTab());

        private void ShowWarehouseTab(object sender, EventArgs e) => _view.ShowTab(new WarehouseTab());

        private void ShowCRMTab(object sender, EventArgs e) => _view.ShowTab(new CRMTab());

        private void ShowContractorsTab(object sender, EventArgs e) => _view.ShowTab(new ContractorsTab());
    }
}
