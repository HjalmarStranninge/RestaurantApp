using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public int TableNumber { get; set; }
        public bool IsAvailable { get; set; } = true;
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
