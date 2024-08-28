using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Services
{
    public class TableService : ITableService
    {
        public Task<(bool, string)> CreateTableAsync(TableDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> DeleteTableAsync(int tableId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TableDTO>> GetAllTablesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> UpdateTableAsync(TableDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
