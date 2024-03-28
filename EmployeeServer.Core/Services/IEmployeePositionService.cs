using EmployeeServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Core.Services
{
    public interface IEmployeePositionService
    {
        // Get all employee positions
        Task<IEnumerable<EmployeePosition>> GetEmployeePositionsAsync();

        // Get employee position by ID
        Task<EmployeePosition> GetEmployeePositionByIdAsync(int employeeId, int positionId);

        // Add employee position
        Task AddEmployeePositionAsync(EmployeePosition employeePosition);

        // Update employee position
        Task UpdateEmployeePositionAsync(EmployeePosition employeePosition);

        // Delete employee position
        Task DeleteEmployeePositionAsync(int employeeId, int positionId);

        // Get employee positions by employee ID
        Task<IEnumerable<EmployeePosition>> GetEmployeePositionsByEmployeeIdAsync(int employeeId);

        // Get employee positions by position ID
        Task<IEnumerable<EmployeePosition>> GetEmployeePositionsByPositionIdAsync(int positionId);

        // Get current employee position by employee ID
        Task<EmployeePosition> GetCurrentEmployeePositionByEmployeeIdAsync(int employeeId);
    }
}
