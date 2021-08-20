using MediatR;
using System.Collections.Generic;

namespace CompanyName.HousingManagementSystem.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery: IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
