using System;
using System.Windows.Forms;
using CarRepairShop.MainForm.Views.MainView;

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

            using (var loginForm = new LoginForm.View.LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Application.Run(new MainView());
                }
            }

        }
    }
}
