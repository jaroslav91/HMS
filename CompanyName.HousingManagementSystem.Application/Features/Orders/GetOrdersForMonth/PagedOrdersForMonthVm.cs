using System.Collections.Generic;

namespace CompanyName.HousingManagementSystem.Application.Features.Orders.GetOrdersForMonth
{
    public class PagedOrdersForMonthVm
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public ICollection<OrdersForMonthDto> OrdersForMonth{ get; set; }
    }
}