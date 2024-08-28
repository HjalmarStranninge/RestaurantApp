using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();
        Task CreateCustomerAsync(CustomerDTO dto);
        Task UpdateCustomerAsync(CustomerDTO dto);
        Task DeleteCustomerAsync(int customerId);
    }
}
