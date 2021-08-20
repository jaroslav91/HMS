using CompanyName.HousingManagementSystem.App.Services.Base;
using CompanyName.HousingManagementSystem.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.App.Contracts
{
    public interface IEventDataService
    {
        Task<List<EventListViewModel>> GetAllEvents();
        Task<EventDetailViewModel> GetEventById(Guid id);
        Task<ApiResponse<Guid>> CreateEvent(EventDetailViewModel eventDetailViewModel);
        Task<ApiResponse<Guid>> UpdateEvent(EventDetailViewModel eventDetailViewModel);
        Task<ApiResponse<Guid>> DeleteEvent(Guid id);
    }
}
