using CompanyName.HousingManagementSystem.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanyName.HousingManagementSystem.Identity
{
    public class HousingManagementSystemIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public HousingManagementSystemIdentityDbContext(DbContextOptions<HousingManagementSystemIdentityDbContext> options) : base(options)
        {
        }
    }
}
