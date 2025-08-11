using CarRepairShop.MainForm.Views.MainView;
using CarRepairShop.MainForm.Views.Tabs.ContractorsTab;
using CarRepairShop.MainForm.Views.Tabs.CRM;
using CarRepairShop.MainForm.Views.Tabs.Home;
using CarRepairShop.MainForm.Views.Tabs.Services;
using CarRepairShop.MainForm.Views.Tabs.Settings;
using CarRepairShop.Utilities.Permissions;
using System;

namespace CarRepairShop.MainForm.Presenters.MainForm
{
    public class MainViewPresenter
    {
        private readonly IMainView _view;

        public MainViewPresenter(IMainView view)
        {
            _view = view;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.ContractorTabButtonClicked += ShowContractorsTab;
            _view.CRMTabButtonClicked += ShowCRMTab;
            _view.WarehouseTabButtonClicked += ShowWarehouseTab;
            _view.UsersTabButtonClicked += ShowUsersTab;
            _view.ServicesTabButtonClicked += ShowServicesTab;
            _view.SettingsButtonClicked += ShowSettingsTab;
            _view.HomeButtonClicked += ShowHomeTab;
            _view.MainFormIsLoaded += OnMainFormLoaded;
        }

        private void OnMainFormLoaded(object sender, EventArgs e) => _view.ShowTab(new HomeTab());

        private void ShowHomeTab(object sender, EventArgs e)
        {
            _view.ShowTab(new HomeTab());
            _view.HighlightButton(sender as System.Windows.Forms.Button);
        }

        private void ShowSettingsTab(object sender, EventArgs e) => _view.ShowTab(new SettingsTab());

        private void ShowServicesTab(object sender, EventArgs e)
        {
            if (UserHasViewPermissions(PermissionTabs.Services, Permissions.AllowDisplay))
            {
                _view.ShowTab(new ServicesTab());
                _view.HighlightButton(sender as System.Windows.Forms.Button);
            }
            else
                _view.ShowMessage("Nie masz uprawnień do wyświetlania zakładki: Usługi!");
        }
        private void ShowUsersTab(object sender, EventArgs e)
        {
            if (UserHasViewPermissions(PermissionTabs.Services, Permissions.AllowDisplay))
            {
                _view.ShowTab(new UsersTab());
                _view.HighlightButton(sender as System.Windows.Forms.Button);
            }
            else
                _view.ShowMessage("Nie masz uprawnień do wyświetlania zakładki: Użytkownicy!");
        }
        private void ShowWarehouseTab(object sender, EventArgs e)
        {
            if (UserHasViewPermissions(PermissionTabs.Services, Permissions.AllowDisplay))
            {
                _view.ShowTab(new WarehouseTab());
                _view.HighlightButton(sender as System.Windows.Forms.Button);
            }
            else
                _view.ShowMessage("Nie masz uprawnień do wyświetlania zakładki: Magazyn!");
        }
        private void ShowCRMTab(object sender, EventArgs e)
        {
            if (UserHasViewPermissions(PermissionTabs.Services, Permissions.AllowDisplay))
            {
                _view.ShowTab(new CRMTab());
                _view.HighlightButton(sender as System.Windows.Forms.Button);
            }
            else
                _view.ShowMessage("Nie masz uprawnień do wyświetlania zakładki: CRM!");
        }
        private void ShowContractorsTab(object sender, EventArgs e)
        {
            if (UserHasViewPermissions(PermissionTabs.Services, Permissions.AllowDisplay))
            {
                _view.ShowTab(new ContractorsTab());
                _view.HighlightButton(sender as System.Windows.Forms.Button);
            }
            else
                _view.ShowMessage("Nie masz uprawnień do wyświetlania zakładki: Kontrahenci!");
        }

        public bool UserHasViewPermissions(PermissionTabs permissionTab, Permissions permission) => AppSettings.CurrentUser.HasPermission(permissionTab, permission) ? true : false;
    }
}
