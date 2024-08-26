using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateCustomer()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCustomer()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> UpdateCustomerInfo()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult> GetAllCustomers()
        {
            return Ok();
        }
    }
}
