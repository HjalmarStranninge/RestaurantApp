﻿namespace RestaurantApp.Models.DTOs
{
    public class BookingRequestDTO
    {
        public int PartySize { get; set; }
        public DateTime RequestedDateTime { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}
