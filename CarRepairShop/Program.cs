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

            var dbHandler = new Repos.DataBaseHandler();
            dbHandler.SetConnectionStringAsync().GetAwaiter().GetResult();

            using (var loginForm = new LoginForm.View.LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                    Application.Run(new MainView());
            }

        }
    }
}
