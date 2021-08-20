using AutoMapper;
using Blazored.LocalStorage;
using CompanyName.HousingManagementSystem.App.Contracts;
using CompanyName.HousingManagementSystem.App.Services.Base;
using CompanyName.HousingManagementSystem.App.ViewModels;
using System;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.App.Services
{
    public class OrderDataService : BaseDataService, IOrderDataService
    {
        private readonly IMapper _mapper;

        public OrderDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size)
        {
            var orders = await _client.GetPagedOrdersForMonthAsync(date, page, size);
            var mappedOrders = _mapper.Map<PagedOrderForMonthViewModel>(orders);
            return mappedOrders;
        }
    }
}
