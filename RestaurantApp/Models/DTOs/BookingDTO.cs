using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public int PartySize { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
    }
}
