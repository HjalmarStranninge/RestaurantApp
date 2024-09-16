using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models.DTOs
{
    public class TableCreateDTO
    {
        public int Seats { get; set; }
        public int TableNumber { get; set; }
    }
}

