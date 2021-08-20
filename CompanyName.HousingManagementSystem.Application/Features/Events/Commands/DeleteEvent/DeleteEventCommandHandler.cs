using AutoMapper;
using CompanyName.HousingManagementSystem.Application.Contracts.Persistence;
using CompanyName.HousingManagementSystem.Application.Exceptions;
using CompanyName.HousingManagementSystem.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;
        
        public DeleteEventCommandHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.EventId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(Event), request.EventId);
            }

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
