using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public bool isAppetizer { get; set; }
        public bool isMainCourse{ get; set; }
        public bool isDesert{ get; set; }
        public bool isCocktail{ get; set; }
    }
}
