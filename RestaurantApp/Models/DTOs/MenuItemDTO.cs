using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class MenuItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
