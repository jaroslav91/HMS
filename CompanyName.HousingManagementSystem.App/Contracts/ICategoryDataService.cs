using CompanyName.HousingManagementSystem.App.Services;
using CompanyName.HousingManagementSystem.App.Services.Base;
using CompanyName.HousingManagementSystem.App.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyName.HousingManagementSystem.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}
