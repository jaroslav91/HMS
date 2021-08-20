using AutoMapper;
using CompanyName.HousingManagementSystem.Application.Contracts.Persistence;
using CompanyName.HousingManagementSystem.Application.Features.Categories.Queries.GetCategoriesList;
using CompanyName.HousingManagementSystem.Application.Profiles;
using CompanyName.HousingManagementSystem.Application.UnitTests.Mocks;
using CompanyName.HousingManagementSystem.Domain.Entities;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CompanyName.HousingManagementSystem.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
