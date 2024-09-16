using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly RestaurantAppContext _context;

        public MenuItemRepository(RestaurantAppContext context)
        {
            _context = context;
        }

        public async Task CreateMenuItemAsync(MenuItem menuItem)
        {
            await _context.AddAsync(menuItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMenuItemAsync(int menuItemId)
        {
            var menuItem = await _context.MenuItems.FindAsync(menuItemId);
            if (menuItem != null)
            {
                _context.MenuItems.Remove(menuItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<MenuItem>> GetAllMenuItemsAsync()
        {
            return await _context.MenuItems.ToListAsync();
        }

        public async Task<MenuItem> GetMenuItemByIdAsync(int menuItemId)
        {
            return await _context.MenuItems.FindAsync(menuItemId);
        }

        public async Task UpdateMenuItemAsync(MenuItem menuItem)
        {
            _context.MenuItems.Update(menuItem);
            await _context.SaveChangesAsync();
        }
    }
}
