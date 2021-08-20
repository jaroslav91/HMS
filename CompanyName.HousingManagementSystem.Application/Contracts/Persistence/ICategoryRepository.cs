using CompanyName.HousingManagementSystem.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
