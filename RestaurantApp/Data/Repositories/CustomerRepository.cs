using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task CreateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
