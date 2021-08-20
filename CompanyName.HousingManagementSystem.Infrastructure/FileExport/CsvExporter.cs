using CsvHelper;
using CompanyName.HousingManagementSystem.Application.Contracts.Infrastructure;
using CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;
using System.IO;

namespace CompanyName.HousingManagementSystem.Infrastructure
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.InvariantCulture, false);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
