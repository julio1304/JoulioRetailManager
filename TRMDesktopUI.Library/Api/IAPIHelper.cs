using System.Net.Http;
using System.Threading.Tasks;
using TRMDataManager.Models;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
        void LogOffUser();
    }
}