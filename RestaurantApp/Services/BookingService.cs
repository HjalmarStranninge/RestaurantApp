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
        private readonly ICustomerService _customerService;
        public BookingService(IBookingRepository bookingRepository, ITableService tableService, ICustomerService customerService)
        {
            _bookingRepository = bookingRepository;
            _tableService = tableService;
            _customerService = customerService;
        }

        public async Task<(bool, string)> CreateBookingAsync(BookingRequestDTO dto)
        {
            var table = await _tableService.FindAvailableTableAsync(dto.PartySize, dto.RequestedDateTime);

            if (table == null)
            {
                return (false, "There are no available tables.");
            }

            var customerDTO = new CustomerDTO
            {
                FirstName = dto.CustomerFirstName,
                LastName = dto.CustomerLastName,
                PhoneNumber = dto.CustomerPhone,
                Email = dto.CustomerEmail
            };

            try
            {
                await _customerService.CreateCustomerAsync(customerDTO);
            }
            catch (Exception ex)
            {
                return (false, $"Something went wrong when registering customer data: {ex}");
            }

            var booking = new Booking
            {
                Customer = await _customerService.GetCustomerByPhoneNumberAsync(dto.CustomerPhone),
                PartySize = dto.PartySize,
                StartDateTime = dto.RequestedDateTime,
                EndDateTime = dto.RequestedDateTime.AddHours(2),
                Table = table,
            };

            try
            {
                await _bookingRepository.CreateBookingAsync(booking);
                return (true, "The requested sitting has now been booked.");
            }
            catch (Exception ex)
            {

                return (false, $"Something went wrong when booking: {ex}");
            }
        }

        public Task<(bool, string)> DeleteBookingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookingDTO>> GetAllBookingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookingDTO> GetBookingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> UpdateBookingAsync(BookingDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
