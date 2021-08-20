using CompanyName.HousingManagementSystem.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
