using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public async Task<(bool, string)> CreateMenuItemAsync(MenuItemCreateDTO dto)
        {
            var menuItem = new MenuItem
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                IsAvailable = dto.IsAvailable
            };

            try
            {
                await _menuItemRepository.CreateMenuItemAsync(menuItem);
                return (true, "Menu item created successfully!");
            }
            catch (Exception)
            {
                return (false, "Something went wrong when adding new menu item to database.");
            }
        }

        public async Task<(bool, string)> UpdateMenuItemAsync(MenuItemDTO dto)
        {
            var menuItem = new MenuItem
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                IsAvailable = dto.IsAvailable
            };

            try
            {
                await _menuItemRepository.UpdateMenuItemAsync(menuItem);
                return (true, "Menu item updated successfully!");
            }
            catch (Exception)
            {
                return (false, "Menu item couldn't be updated.");
            }
        }

        public async Task<(bool, string)> DeleteMenuItemAsync(int id)
        {
            try
            {
                await _menuItemRepository.DeleteMenuItemAsync(id);
                return (true, "Menu item deleted successfully!");
            }
            catch (Exception)
            {
                return (false, "Menu item couldn't be deleted.");
            }
        }

        public async Task<MenuItemDTO> GetMenuItemAsync(int id)
        {
            var menuItem = await _menuItemRepository.GetMenuItemByIdAsync(id);
            if (menuItem == null)
            {
                return null;
            }

            return new MenuItemDTO
            {
                Id = menuItem.Id,
                Name = menuItem.Name,
                Description = menuItem.Description,
                Price = menuItem.Price,
                IsAvailable = menuItem.IsAvailable
            };
        }

        public async Task<IEnumerable<MenuItemDTO>> GetAllMenuItemsAsync()
        {
            var menuItems = await _menuItemRepository.GetAllMenuItemsAsync();
            var menuItemList = new List<MenuItemDTO>();

            foreach (var menuItem in menuItems)
            {
                var dto = new MenuItemDTO
                {
                    Id = menuItem.Id,
                    Name = menuItem.Name,
                    Description = menuItem.Description,
                    Price = menuItem.Price,
                    IsAvailable = menuItem.IsAvailable
                };
                menuItemList.Add(dto);
            }

            return menuItemList;
        }
    }
}
