using CompanyName.HousingManagementSystem.App.ViewModels;
using System;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.App.Contracts
{
    public interface IOrderDataService
    {
        Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size);
    }
}
