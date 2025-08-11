using System.Threading.Tasks;

namespace CarRepairShop.Utilities.WebBrowser
{
    public class WebBrowserHandler : IWebBrowserHandler
    {
        public Task<bool> OpenURL(string url) => WebBrowser.OpenURL(url);
    }
}
