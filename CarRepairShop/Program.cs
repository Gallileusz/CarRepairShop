using CarRepairShop.Authentication.DataBaseConnector.View;
using CarRepairShop.MainForm.Views.MainView;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CarRepairShop
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var cachedLanguage = Properties.Settings.Default.Language;
            var language = string.IsNullOrEmpty(cachedLanguage) ? "en-US" : cachedLanguage;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            var dbConnector = new DataBaseConnectorView();
            dbConnector.ShowDialog();

            if (dbConnector.ConnectionSettingsChanged == DialogResult.Yes)
            {
                Application.Restart(); return;
            }

            using (var loginForm = new LoginForm.View.LoginForm(dbConnector.ConnectionSet == DialogResult.Cancel))
            {
                var result = loginForm.ShowDialog();

                if (result != DialogResult.OK) return;

                Application.Run(new MainView());
            }
        }
    }
}
