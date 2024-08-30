﻿using RestaurantApp.Data.Repositories;
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

        public async Task<(bool, string)> DeleteTableAsync(int tableId)
        {
            try
            {
                await _tableRepository.DeleteTableAsync(tableId);
                return (true, "Table deleted!");
            }
            catch (Exception)
            {
                return (false, "Table couldn't be deleted.");
            }
        }

        public async Task<Table> FindAvailableTableAsync(int requiredSeats, DateTime requestedStartTime)
        {    
            var requestedEndTime = requestedStartTime.AddHours(2);
            return await _tableRepository.FindAvailableTableAsync(requiredSeats, requestedStartTime, requestedEndTime);           
        }

        public async Task<IEnumerable<TableDTO>> GetAllTablesAsync()
        {
            try
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
            catch (Exception ex)
            {

                throw new Exception($"Something went wrong when extracting table list: {ex}");
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
                return (true, "Table info updated!");
            }
            catch (Exception)
            {
                return (false, "Table info couldn't be updated.");
            }
        }       
    }
}
