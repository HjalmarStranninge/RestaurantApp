using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public int PartySize { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int FK_CustomerId { get; set; }
        public int FK_TableId { get; set; }
    }
}
