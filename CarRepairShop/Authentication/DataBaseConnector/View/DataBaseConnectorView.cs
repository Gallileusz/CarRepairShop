using CarRepairShop.Authentication.ConnectionSettings.View;
using CarRepairShop.Authentication.DataBaseConnector.Consts;
using CarRepairShop.Repos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRepairShop.Authentication.DataBaseConnector.View
{
    public partial class DataBaseConnectorView : Form, IDataBaseConnectorView
    {
        public event EventHandler FormLoaded;
        public event EventHandler CancelClicked;
        public event EventHandler ProgressBarTimerTicks;
        public event EventHandler SettingsClicked;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DatabaseTypeName { get => lblDataBaseName.Text; set => lblDataBaseName.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult ConnectionSet { get => _connectionSet; set => _connectionSet = value; }
        private DialogResult _connectionSet = DialogResult.None;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult ConnectionSettingsChanged { get => _connectionSettingsChanged; set => _connectionSettingsChanged = value; }
        private DialogResult _connectionSettingsChanged = DialogResult.None;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProgressValue { get => pb.Value; set => pb.Value = value; }

        private readonly Presenter.DataBaseConnectorPresenter _presenter;

        public DataBaseConnectorView()
        {
            InitializeComponent();
            _presenter = new Presenter.DataBaseConnectorPresenter(this, new AppSettings.ConnectionSetter(), new DataBaseHandler());
        }

        public void CloseForm() => this.Close();

        public void SetProgressBarProperties()
        {
            pb.Style = ProgressBarStyle.Marquee;
            pb.Minimum = ViewConsts.ProgressBarMinValue;
            pb.Maximum = ViewConsts.ProgressBarMaxValue;
            pb.Value = ViewConsts.ProgressBarMinValue;
        }

        public void StartConnectionProgress()
        {
            pb.Value = ViewConsts.ProgressBarMinValue;
            ProgressTimer.Start();
        }

        public void StopConnectionProgress()
        {
            ProgressTimer.Stop();
            pb.Value = ViewConsts.ProgressBarMinValue;
        }

        public DialogResult OpenSettingsForm()
        {
            var form = new ConnectionSettingsView();
            form.ShowDialog();

            return form.ChangesAccured;
        }

        private void DataBaseConnectorView_Load(object sender, EventArgs e) => FormLoaded?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelClicked?.Invoke(sender, e);

        private void ProgressTimer_Tick(object sender, EventArgs e) => ProgressBarTimerTicks?.Invoke(sender, e);

        private void btnSettings_Click(object sender, EventArgs e) => SettingsClicked?.Invoke(sender, e);
    }
}
