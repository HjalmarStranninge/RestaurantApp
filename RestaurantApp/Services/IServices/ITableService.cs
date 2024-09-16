using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;

namespace RestaurantApp.Services.IServices
{
    public interface ITableService
    {
        Task<IEnumerable<TableDTO>> GetAllTablesAsync();
        Task<(bool, string)> CreateTableAsync(TableCreateDTO dto);
        Task<(bool, string)> UpdateTableAsync(TableDTO dto);
        Task<(bool, string)> DeleteTableAsync(int tableId);
        Task<Table> FindAvailableTableAsync(int requiredSeats, DateTime requestedStartTime);
        Task<Table> GetTableByIdAsync(int id);
    }
}
