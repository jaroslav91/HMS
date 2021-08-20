﻿using CompanyName.HousingManagementSystem.Application.Contracts.Persistence;
using CompanyName.HousingManagementSystem.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(HousingManagementSystemDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches =  _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
