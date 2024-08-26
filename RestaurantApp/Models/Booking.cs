using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PartySize { get; set; }
        [Required]
        public DateOnly Date { get; set; }
        [Required]
        public TimeOnly Time { get; set; }

        [ForeignKey("Customer")]
        public int FK_CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Table")]
        public int FK_TableId { get; set; }
        public Table Table { get; set; }

    }
}
