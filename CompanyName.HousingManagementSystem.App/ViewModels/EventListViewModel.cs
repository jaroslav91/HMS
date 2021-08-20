using System;

namespace CompanyName.HousingManagementSystem.App.ViewModels
{
    public class EventListViewModel
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
