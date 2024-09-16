using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories.IRepositories
{
    public interface IMenuItemRepository
    {
        Task<IEnumerable<MenuItem>> GetAllMenuItemsAsync();
        Task CreateMenuItemAsync(MenuItem menuItem);
        Task UpdateMenuItemAsync(MenuItem menuItem);
        Task DeleteMenuItemAsync(int customerId);
        Task<MenuItem> GetMenuItemByIdAsync(int menuItemId);
    }
}
