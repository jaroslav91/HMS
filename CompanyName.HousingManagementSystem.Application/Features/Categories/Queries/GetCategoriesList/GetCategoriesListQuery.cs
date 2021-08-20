using MediatR;
using System.Collections.Generic;

namespace CompanyName.HousingManagementSystem.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
