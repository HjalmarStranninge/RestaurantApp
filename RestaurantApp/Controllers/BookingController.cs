using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        [Route("/makenewbooking")]
        public async Task<IActionResult> MakeNewBooking(BookingRequestDTO dto)
        {
            var (success, message) = await _bookingService.CreateBookingAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpDelete]
        [Route("/deletebooking")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var (success, message) = await _bookingService.DeleteBookingAsync(id);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpPost]
        [Route("/updatebooking")]
        public async Task<IActionResult> UpdateBooking(BookingUpdateDTO dto)
        {
            var (success, message) = await _bookingService.UpdateBookingAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpGet]
        [Route("/getallbookings")]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await _bookingService.GetAllBookingsAsync();
            return Ok(bookings);
        }

        [HttpGet]
        [Route("/getbooking")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var booking = await _bookingService.GetBookingAsync(id);
            if (booking == null)
            {
                return NotFound("Booking not found");
            }
            return Ok(booking);
        }
    }
}
