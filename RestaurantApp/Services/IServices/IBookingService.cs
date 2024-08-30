using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface IBookingService
    {
        Task<(bool, string)> CreateBookingAsync(BookingRequestDTO dto);
        Task<(bool, string)> UpdateBookingAsync(BookingDTO dto);
        Task<(bool, string)> DeleteBookingAsync(int id);
        Task<BookingDTO> GetBookingAsync(int id);
        Task<IEnumerable<BookingDTO>> GetAllBookingsAsync();
    }
}
