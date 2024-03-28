using EmployeeServer.Core.Entities;
using EmployeeServer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Service
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }

        public async Task AddAsync(Employee Employee)
        {
            await _EmployeeRepository.AddAsync(Employee);
        }

        public async Task DeleteAsync(int id)
        {
            await _EmployeeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _EmployeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _EmployeeRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync( Employee Employee)
        {
            await _EmployeeRepository.UpdateAsync( Employee);
        }
    }
}
