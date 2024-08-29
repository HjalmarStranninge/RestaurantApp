using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface IBookingService
    {
        Task<(bool, string)> CreateBooking(BookingRequestDTO dto);
        Task<(bool, string)> UpdateBooking(BookingDTO dto);
        Task<(bool, string)> DeleteBooking(int id);
        Task<BookingDTO> GetBooking(int id);
        Task<IEnumerable<BookingRequestDTO>> GetAllBookings();
    }
}
