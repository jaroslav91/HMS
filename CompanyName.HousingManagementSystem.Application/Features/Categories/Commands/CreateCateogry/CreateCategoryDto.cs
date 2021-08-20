using System;

namespace CompanyName.HousingManagementSystem.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
