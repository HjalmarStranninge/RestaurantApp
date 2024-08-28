using Microsoft.EntityFrameworkCore.Metadata;
using RestaurantApp.Data.Repositories.IRepositories;
using RestaurantApp.Models;

namespace RestaurantApp.Data.Repositories
{
    public class TableRepository : ITableRepository
    {
        private readonly RestaurantAppContext _context;
        public TableRepository(RestaurantAppContext context)
        {
            _context = context;
        }

        public async Task CreateTableAsync(Table table)
        {
            await _context.AddAsync(table);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTableAsync(int tableId)
        {
            var table = await _context.Tables.FindAsync(tableId);
            if (table != null)
            {
                _context.Tables.Remove(table);
                await _context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<Table>> GetAllTablesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTableAsync(Table table)
        {
            throw new NotImplementedException();
        }
    }
}
