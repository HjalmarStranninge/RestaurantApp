using Microsoft.AspNetCore.Http.HttpResults;
using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<(bool, string)> CreateCustomerAsync(CustomerDTO dto)
        {
            var customer = new Customer
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
            };

            try
            {
                await _customerRepository.CreateCustomerAsync(customer);
                return (true, "Customer created successfully!");
            }
            catch (Exception)
            {
                return (false, "Something went wrong when adding new customer to database.");
            }
            

        }

        public async Task<(bool, string)> DeleteCustomerAsync(int customerId)
        {
            try
            {
                await _customerRepository.DeleteCustomerAsync(customerId);
                return (true, "Customer deleted!");
            }
            catch (Exception)
            {
                return (false, "Customer couldn't be deleted.");
            }
            
        }

        public Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> UpdateCustomerAsync(CustomerDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
