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

            var customerDTO = new CustomerCreateDTO
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
                return (true, $"Table {table.TableNumber} successfully booked for {dto.CustomerFirstName} {dto.CustomerLastName} on {dto.RequestedDateTime:MMMM dd, yyyy} at {dto.RequestedDateTime:HH:mm}.");
            }
            catch (Exception ex)
            {
                return (false, $"Something went wrong when booking: {ex}");
            }
        }

        public async Task<(bool, string)> DeleteBookingAsync(int id)
        {
            try
            {
                await _bookingRepository.DeleteBookingAsync(id);
                return (true, "Booking deleted successfully!");
            }
            catch (Exception ex)
            {
                return (false, $"Something went wrong when deleting the booking: {ex}");
            }
        }

        public async Task<IEnumerable<BookingDTO>> GetAllBookingsAsync()
        {
            var bookings = await _bookingRepository.GetAllBookingsAsync();
            var bookingList = new List<BookingDTO>();

            foreach (var booking in bookings)
            {
                var dto = new BookingDTO
                {
                    Id = booking.Id,
                    CustomerId = booking.Customer.Id,
                    TableId = booking.Table.Id,
                    PartySize = booking.PartySize,
                    StartDateTime = booking.StartDateTime,
                    EndDateTime = booking.EndDateTime
                };
                bookingList.Add(dto);
            }

            return bookingList;
        }

        public async Task<Booking> GetBookingAsync(int id)
        {
            return await _bookingRepository.GetBookingAsync(id);
        }

        public async Task<(bool, string)> UpdateBookingAsync(BookingUpdateDTO dto)
        {
            var booking = await _bookingRepository.GetBookingAsync(dto.Id);
            if (booking == null)
            {
                return (false, "Booking not found.");
            }

            booking.PartySize = dto.PartySize;
            booking.StartDateTime = dto.StartDateTime;
            booking.EndDateTime = dto.EndDateTime;

            try
            {
                await _bookingRepository.UpdateBookingAsync(booking);
                return (true, "Booking updated successfully!");
            }
            catch (Exception ex)
            {
                return (false, $"Something went wrong when updating the booking: {ex}");
            }
        }

    }
}
