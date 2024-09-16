using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface IMenuItemService
    {
        Task<(bool, string)> CreateMenuItemAsync(MenuItemCreateDTO dto);
        Task<(bool, string)> UpdateMenuItemAsync(MenuItemDTO dto);
        Task<(bool, string)> DeleteMenuItemAsync(int id);
        Task<MenuItemDTO> GetMenuItemAsync(int id);
        Task<IEnumerable<MenuItemDTO>> GetAllMenuItemsAsync();
    }
}
