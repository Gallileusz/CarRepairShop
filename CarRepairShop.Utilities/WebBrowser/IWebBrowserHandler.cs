using System.Threading.Tasks;

namespace CarRepairShop.Utilities.WebBrowser
{
    public interface IWebBrowserHandler
    {
        Task<bool> OpenURL(string url);
    }
}
