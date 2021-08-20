using MediatR;
using System.Collections.Generic;

namespace CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {

    }
}
