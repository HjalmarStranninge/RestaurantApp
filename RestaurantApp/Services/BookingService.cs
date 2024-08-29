using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;
        public BookingService(IBookingRepository repository)
        {
            _repository = repository;
        }

        public Task<(bool, string)> CreateBooking(BookingDTO dto)
        {
            
        }

        public Task<(bool, string)> DeleteBooking(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookingDTO>> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public Task<BookingDTO> GetBooking(int id)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> UpdateBooking(BookingDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
