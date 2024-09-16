using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface IBookingService
    {
        Task<(bool, string)> CreateBookingAsync(BookingRequestDTO dto);
        Task<(bool, string)> UpdateBookingAsync(BookingUpdateDTO dto);
        Task<(bool, string)> DeleteBookingAsync(int id);
        Task<Booking> GetBookingAsync(int id);
        Task<IEnumerable<BookingDTO>> GetAllBookingsAsync();
    }
}
