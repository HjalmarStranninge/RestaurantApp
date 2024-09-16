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

        public async Task<(bool, string)> CreateTableAsync(TableCreateDTO dto)
        {
            var table = new Table
            {
                Seats = dto.Seats,
                TableNumber = dto.TableNumber
            };

            try
            {
                await _tableRepository.CreateTableAsync(table);
                return (true, "Table created successfully!");
            }
            catch (Exception)
            {
                return (false, "Something went wrong when adding new table to database.");
            }
        }

        public async Task<(bool, string)> UpdateTableAsync(TableDTO dto)
        {
            var table = new Table
            {
                Id = dto.Id,
                Seats = dto.Seats,
                TableNumber = dto.TableNumber
            };

            try
            {
                await _tableRepository.UpdateTableAsync(table);
                return (true, "Table updated successfully!");
            }
            catch (Exception)
            {
                return (false, "Table couldn't be updated.");
            }
        }

        public async Task<(bool, string)> DeleteTableAsync(int id)
        {
            try
            {
                await _tableRepository.DeleteTableAsync(id);
                return (true, "Table deleted successfully!");
            }
            catch (Exception)
            {
                return (false, "Table couldn't be deleted.");
            }
        }

        public async Task<Table> GetTableByIdAsync(int id)
        {
            var table = await _tableRepository.GetTableByIdAsync(id);
            return table;
        }

        public async Task<IEnumerable<TableDTO>> GetAllTablesAsync()
        {
            var tables = await _tableRepository.GetAllTablesAsync();
            var tableList = new List<TableDTO>();

            foreach (var table in tables)
            {
                var dto = new TableDTO
                {
                    Id = table.Id,
                    Seats = table.Seats,
                    TableNumber = table.TableNumber
                };
                tableList.Add(dto);
            }

            return tableList;
        }

        public async Task<Table> FindAvailableTableAsync(int requiredSeats, DateTime requestedStartTime)
        {
            var requestedEndTime = requestedStartTime.AddHours(2);
            return await _tableRepository.FindAvailableTableAsync(requiredSeats, requestedStartTime, requestedEndTime);
        }
    }
}

