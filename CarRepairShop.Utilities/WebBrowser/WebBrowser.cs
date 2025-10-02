using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CarRepairShop.Utilities.WebBrowser
{
    public static class WebBrowser
    {
        public static async Task<bool> OpenURL(string url)
        {
            url = url?.Trim();

            if (string.IsNullOrWhiteSpace(url)) return false;

            try
            {
                Process.Start(url); return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
