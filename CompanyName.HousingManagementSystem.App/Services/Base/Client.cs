using System.Net.Http;

namespace CompanyName.HousingManagementSystem.App.Services
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}
