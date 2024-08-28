using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();
        Task<(bool, string)> CreateCustomerAsync(CustomerDTO dto);
        Task<(bool, string)> UpdateCustomerAsync(CustomerDTO dto);
        Task<(bool, string)> DeleteCustomerAsync(int customerId);
    }
}
