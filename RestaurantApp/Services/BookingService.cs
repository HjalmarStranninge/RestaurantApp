using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly ITableService _tableService;
        public BookingService(IBookingRepository bookingRepository, ITableService tableService)
        {
            _bookingRepository = bookingRepository;
            _tableService = tableService;
        }

        public async Task<(bool, string)> CreateBooking(BookingRequestDTO dto)
        {
            var tableId = await _tableService.FindAvailableTableAsync(dto.PartySize);

            if (tableId == 0)
            {
                return (false, "There are no available tables.");
            }

            var booking = new Booking
            {

            }
            _bookingRepository.CreateBooking
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
