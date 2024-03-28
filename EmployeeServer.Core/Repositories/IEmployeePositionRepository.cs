using EmployeeServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Core.Repositories
{
    public interface IEmployeePositionRepository
    {
        Task<EmployeePosition> AddPositionToEmployeeAsync(EmployeePosition EmployeePosition);
        Task<EmployeePosition> UpdatePositionToEmployeeAsync(int employeeId, int positionId, EmployeePosition EmployeePosition);
        Task<bool> DeletePositionOfEmployeeAsync(int employeeId, int positionId);
        Task<IEnumerable<EmployeePosition>> GetEmployeePositionsAsync(int employeeId);



    }
}
