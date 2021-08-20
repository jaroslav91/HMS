using CompanyName.HousingManagementSystem.Application.Models.Authentication;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
