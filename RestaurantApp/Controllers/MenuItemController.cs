using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpPost]
        [Route("/createmenuitem")]
        public async Task<ActionResult> CreateMenuItem(MenuItemCreateDTO dto)
        {
            var (success, message) = await _menuItemService.CreateMenuItemAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpDelete]
        [Route("/deletemenuitem")]
        public async Task<ActionResult> DeleteMenuItem(int id)
        {
            var (success, message) = await _menuItemService.DeleteMenuItemAsync(id);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpPost]
        [Route("/updatemenuitem")]
        public async Task<ActionResult> UpdateMenuItem(MenuItemDTO dto)
        {
            var (success, message) = await _menuItemService.UpdateMenuItemAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpGet]
        [Route("/getallmenuitems")]
        public async Task<ActionResult> GetAllMenuItems()
        {
            var menuItems = await _menuItemService.GetAllMenuItemsAsync();
            return Ok(menuItems);
        }

        [HttpGet]
        [Route("/getmenuitem")]
        public async Task<ActionResult> GetMenuItem(int id)
        {
            var menuItem = await _menuItemService.GetMenuItemAsync(id);
            if (menuItem == null)
            {
                return NotFound("Menu item not found");
            }
            return Ok(menuItem);
        }
    }
}
