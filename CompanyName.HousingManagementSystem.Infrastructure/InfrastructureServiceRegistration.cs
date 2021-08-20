using CompanyName.HousingManagementSystem.Application.Contracts.Infrastructure;
using CompanyName.HousingManagementSystem.Application.Models.Mail;
using CompanyName.HousingManagementSystem.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyName.HousingManagementSystem.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
