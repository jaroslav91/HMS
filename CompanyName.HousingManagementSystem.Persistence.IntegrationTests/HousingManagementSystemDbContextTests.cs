using CompanyName.HousingManagementSystem.Application.Contracts;
using CompanyName.HousingManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace CompanyName.HousingManagementSystem.Persistence.IntegrationTests
{
    public class HousingManagementSystemDbContextTests
    {
        private readonly CompanyNameDbContext _CompanyNameDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public HousingManagementSystemDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<CompanyNameDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _CompanyNameDbContext = new CompanyNameDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var ev = new Event() {EventId = Guid.NewGuid(), Name = "Test event" };

            _CompanyNameDbContext.Events.Add(ev);
            await _CompanyNameDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
