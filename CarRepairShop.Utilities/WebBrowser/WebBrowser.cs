using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarRepairShop.Utilities.WebBrowser
{
    public static class WebBrowser
    {
        public static async Task<bool> OpenURL(string url)
        {
            url = url?.Trim();

            if (string.IsNullOrWhiteSpace(url)) return false;

            var correctUrl = await UrlRespondsAsync(url);

            if (!correctUrl) return false;

            try
            {
                Process.Start(url); return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static async Task<bool> UrlRespondsAsync(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
