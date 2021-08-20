using MediatR;

namespace CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery: IRequest<EventExportFileVm>
    {
    }
}
