using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class TableDTO
    {
        public int Id { get; set; }
        public int Seats { get; set; }
        public int TableNumber { get; set; }
    }
}
