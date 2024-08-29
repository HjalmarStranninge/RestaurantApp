using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface IBookingService
    {
        Task<(bool, string)> CreateBooking(BookingDTO bookingDTO);
        Task<(bool, string)> UpdateBooking(BookingDTO bookingDTO);
        Task<(bool, string)> DeleteBooking(int id);
        Task<BookingDTO> GetBooking(int id);
        Task<IEnumerable<BookingDTO>> GetAllBookings();
    }
}
