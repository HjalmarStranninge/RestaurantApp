using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories.IRepositories
{
    public interface ITableRepository
    {
        Task<IEnumerable<Table>> GetAllTablesAsync();
        Task CreateTableAsync(Table table);
        Task UpdateTableAsync(Table table);
        Task DeleteTableAsync(int tableId);
    }
}
