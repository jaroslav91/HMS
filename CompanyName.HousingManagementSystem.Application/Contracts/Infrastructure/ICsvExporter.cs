using CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace CompanyName.HousingManagementSystem.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
