using System;
using System.Windows.Forms;

namespace CarRepairShop.Authentication.DataBaseConnector.View
{
    public interface IDataBaseConnectorView
    {
        event EventHandler FormLoaded;
        event EventHandler CancelClicked;
        event EventHandler ProgressBarTimerTicks;
        event EventHandler SettingsClicked;

        DialogResult ConnectionSet { get; set; }
        DialogResult ConnectionSettingsChanged { get; set; }
        DialogResult OpenSettingsForm();
        string DatabaseTypeName { get; set; }
        int ProgressValue { get; set; }
        void CloseForm();
        void SetProgressBarProperties();
        void StartConnectionProgress();
        void StopConnectionProgress();
    }
}
