using System.Net.Http;

namespace CompanyName.HousingManagementSystem.App.Services
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }

    }
}
