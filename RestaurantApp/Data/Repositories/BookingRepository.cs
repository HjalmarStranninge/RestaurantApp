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

        public async Task CreateBookingAsync(Booking booking)
        {
            await _context.AddAsync(booking);
            _context.SaveChanges();
        }

        public async Task DeleteBookingAsync(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _context.Bookings.Include(b => b.Customer).Include(b => b.Table).ToListAsync();          
        }


        public async Task<Booking> GetBookingAsync(int id)
        {
            return await _context.Bookings.FindAsync(id);          
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }
    }
}
