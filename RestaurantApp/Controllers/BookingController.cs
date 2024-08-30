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
    }
}
