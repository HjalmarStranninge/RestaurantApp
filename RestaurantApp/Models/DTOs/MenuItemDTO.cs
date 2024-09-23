using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class MenuItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool isAppetizer { get; set; }
        public bool isMainCourse { get; set; }
        public bool isDesert { get; set; }
        public bool isCocktail { get; set; }
    }
}
