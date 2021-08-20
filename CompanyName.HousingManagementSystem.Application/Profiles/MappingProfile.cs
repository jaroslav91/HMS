using AutoMapper;
using CompanyName.HousingManagementSystem.Application.Features.Categories.Commands.CreateCateogry;
using CompanyName.HousingManagementSystem.Application.Features.Categories.Queries.GetCategoriesList;
using CompanyName.HousingManagementSystem.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using CompanyName.HousingManagementSystem.Application.Features.Events.Commands.CreateEvent;
using CompanyName.HousingManagementSystem.Application.Features.Events.Commands.UpdateEvent;
using CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventDetail;
using CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventsExport;
using CompanyName.HousingManagementSystem.Application.Features.Events.Queries.GetEventsList;
using CompanyName.HousingManagementSystem.Application.Features.Orders.GetOrdersForMonth;
using CompanyName.HousingManagementSystem.Domain.Entities;

namespace CompanyName.HousingManagementSystem.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
