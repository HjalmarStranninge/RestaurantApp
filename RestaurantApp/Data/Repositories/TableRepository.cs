using Microsoft.EntityFrameworkCore;
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

        // Returns an available table. Prioritizes tables that match the required amount of seats.
        public async Task<Table> FindAvailableTableAsync(int requiredSeats)
        {
            return await _context.Tables
                .Where(t => t.IsAvailable)
                .OrderBy(t => t.Seats >= requiredSeats ? 0 : 1)
                .ThenBy(t => t.Seats)
                .FirstOrDefaultAsync(t => t.Seats >= requiredSeats);
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

        public async Task<IEnumerable<Table>> GetAllTablesAsync()
        {
            var tables = await _context.Tables.ToListAsync();
            return tables;
        }

        public async Task UpdateTableAsync(Table table)
        {
            _context.Tables.Update(table);
            await _context.SaveChangesAsync();
        }
    }
}
