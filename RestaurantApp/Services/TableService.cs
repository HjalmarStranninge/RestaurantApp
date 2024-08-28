using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;
using RestaurantApp.Models.DTOs;
using RestaurantApp.Services.IServices;

namespace RestaurantApp.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
        public async Task<(bool, string)> CreateTableAsync(TableDTO dto)
        {
            var table = new Table
            {
                Id = dto.Id,
                Seats = dto.Seats,
                TableNumber = dto.TableNumber
            };

            try
            {
                await _tableRepository.CreateTableAsync(table);
                return (true, "Table added successfully!");
            }
            catch (Exception)
            {
                return (false, "Something went wrong when adding new table.");
            }
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
