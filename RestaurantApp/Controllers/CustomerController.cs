using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("/createcustomer")]
        public async Task<ActionResult> CreateCustomer(CustomerDTO dto)
        {
            var (success, message) = await _customerService.CreateCustomerAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);

        }

        [HttpDelete]
        [Route("/deletecustomer")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            var (success, message) = await _customerService.DeleteCustomerAsync(id);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpPost]
        [Route("/updatecustomer")]
        public async Task<ActionResult> UpdateCustomerInfo(CustomerDTO dto)
        {
            var (success, message) = await _customerService.UpdateCustomerAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpGet]
        [Route("/getallcustomers")]
        public async Task<ActionResult> GetAllCustomers()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            return Ok(customers);
        }
    }
}
