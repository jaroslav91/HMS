using CompanyName.HousingManagementSystem.Application.Models.Mail;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
