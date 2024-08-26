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
        public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
