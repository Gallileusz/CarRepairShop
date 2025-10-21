using CarRepairShop.AppSettings;
using CarRepairShop.Authentication.DataBaseConnector.Consts;
using CarRepairShop.Authentication.DataBaseConnector.View;
using CarRepairShop.Repos;
using CarRepairShop.Repositories;
using CarRepairShop.Settings;
using System;
using System.Threading.Tasks;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Authentication.DataBaseConnector.Presenter
{
    public class DataBaseConnectorPresenter
    {
        private readonly IDataBaseConnectorView _view;
        private readonly ConnectionSetter _connectionSetter;
        private readonly DataBaseHandler _dbHandler;
        private TablePresenceChecker.TablePresenceChecker _tableChecker;
        public DataBaseConnectorPresenter(IDataBaseConnectorView view, ConnectionSetter connectionSetter, DataBaseHandler dbHandler)
        {
            _view = view;
            _connectionSetter = connectionSetter;
            _dbHandler = dbHandler;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += Load;
            _view.ProgressBarTimerTicks += AnimateProgress;
            _view.CancelClicked += CancelConnection;
            _view.SettingsClicked += OpenSettings;
        }

        private async void Load(object sender, EventArgs e)
        {
            _view.ConnectionSet = System.Windows.Forms.DialogResult.Cancel;
            _view.StopConnectionProgress();
            _view.SetProgressBarProperties();
            _view.StartConnectionProgress();

            await SetDatabaseConnection();
        }

        private async Task SetDatabaseConnection()
        {
            _connectionSetter.SetConnectionProvider();
            await _dbHandler.SetConnectionStringAsync();

            if (!ConnectionProvider.ProductionConnection)
                _view.DatabaseTypeName = Translations.DataBaseConnector.DemoTitle;

            if (await DataBaseReponses())
            {
                _tableChecker = new TablePresenceChecker.TablePresenceChecker(new GenericRepository());

                if (await _tableChecker.CreateNeededTablesIfNeeded())
                {
                    _view.ConnectionSet = System.Windows.Forms.DialogResult.Yes;
                    _view.CloseForm();
                    return;
                }
            }

            _view.ConnectionSet = System.Windows.Forms.DialogResult.No;
            _view.CloseForm();
        }

        private async Task<bool> DataBaseReponses()
        {
            var dbResponded = false;
            var attempts = 1;

            while (!dbResponded && attempts <= PresenterConsts.MaxConnectionAttempts)
            {
                dbResponded = await _dbHandler.TryDatabaseConnectionAsync();

                if (!dbResponded)
                {
                    await Task.Delay(PresenterConsts.AttemptDelay);
                    attempts++;
                }
            }

            return dbResponded;
        }


        private void OpenSettings(object sender, EventArgs e)
        {
            var needsRestart = _view.OpenSettingsForm();
            if (needsRestart == System.Windows.Forms.DialogResult.Yes)
            {
                _view.ConnectionSettingsChanged = System.Windows.Forms.DialogResult.Yes;
                _view.CloseForm();
            }
        }

        private void CancelConnection(object sender, EventArgs e) => _view.CloseForm();

        private void AnimateProgress(object sender, EventArgs e) => _view.ProgressValue = _view.ProgressValue >= PresenterConsts.ProgressBarMaxValue
            ? PresenterConsts.ProgressBarMinValue
            : _view.ProgressValue++;
    }
}
