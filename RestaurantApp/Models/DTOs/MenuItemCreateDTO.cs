using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class MenuItemCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
