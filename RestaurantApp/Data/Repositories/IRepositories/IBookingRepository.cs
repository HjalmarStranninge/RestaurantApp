using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories.IRepositories
{
    public interface IBookingRepository
    {
        Task CreateBooking(Booking booking);
        Task UpdateBooking(Booking booking);
        Task DeleteBooking(int id);
        Task<Booking> GetBooking(int id);
        Task<IEnumerable<Booking>> GetAllBookings();
    }
}
