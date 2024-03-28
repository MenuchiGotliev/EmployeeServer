using EmployeeServer.Core.Entities;
using EmployeeServer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Data.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _dataContext.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _dataContext.Employees.ToListAsync();
        }

        public async Task AddAsync(Employee employee)
        {
            await _dataContext.Employees.AddAsync(employee);
             await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _dataContext.Employees.Update(employee);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _dataContext.Employees.FindAsync(id);
            _dataContext.Employees.Remove(employee);
            await _dataContext.SaveChangesAsync();
        }

   
    }
}



