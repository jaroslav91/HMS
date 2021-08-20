using CompanyName.HousingManagementSystem.Application.Responses;

namespace CompanyName.HousingManagementSystem.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse: BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; }
    }
}