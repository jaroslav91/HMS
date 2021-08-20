using MediatR;
using System;

namespace CompanyName.HousingManagementSystem.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand: IRequest
    {
        public Guid EventId { get; set; }
    }
}
