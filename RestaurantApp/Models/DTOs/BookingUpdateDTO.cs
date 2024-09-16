namespace RestaurantApp.Models.DTOs
{
    public class BookingUpdateDTO
    {
        public int Id { get; set; }
        public int PartySize { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
