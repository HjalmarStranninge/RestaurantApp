using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories.IRepositories
{
    public interface IBookingRepository
    {
        Task CreateBookingAsync(Booking booking);
        Task UpdateBookingAsync(Booking booking);
        Task DeleteBookingAsync(int id);
        Task<Booking> GetBookingAsync(int id);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
    }
}
