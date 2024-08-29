using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories
{
    public class BookingRepository :IBookingRepository
    {
        private readonly RestaurantAppContext _context;

        public BookingRepository(RestaurantAppContext context)
        {
            _context = context;
        }

        public async Task CreateBooking(Booking booking)
        {
            _context.AddAsync(booking);
            _context.SaveChanges();
        }

        public async Task DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            var bookings = await _context.Bookings.ToListAsync();
            return bookings;
        }

        public async Task<Booking> GetBooking(int id)
        {
            return await _context.Bookings.FindAsync(id);          
        }

        public async Task UpdateBooking(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }
    }
}
