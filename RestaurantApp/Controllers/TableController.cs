using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;
        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpPost]
        [Route("/createtable")]
        public async Task<ActionResult> CreateTable(TableDTO dto)
        {
            var (success, message) = await _tableService.CreateTableAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpDelete]
        [Route("/deletetable")]
        public async Task<ActionResult> DeleteTable(int id)
        {
            var (success, message) = await _tableService.DeleteTableAsync(id);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpPost]
        [Route("/updatetable")]
        public async Task<ActionResult> UpdateTableInfo(TableDTO dto)
        {
            var (success, message) = await _tableService.UpdateTableAsync(dto);

            if (success)
            {
                return Ok(message);
            }
            return BadRequest(message);
        }

        [HttpGet]
        [Route("/getalltables")]
        public async Task<ActionResult> GetAllTables()
        {
            var tables = await _tableService.GetAllTablesAsync();
            return Ok(tables);
        }
    }
}
