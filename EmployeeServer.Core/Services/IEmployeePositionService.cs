﻿using EmployeeServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Core.Services
{
    public interface IEmployeePositionService
    {
        Task<EmployeePosition> AddPositionToEmployeeAsync(EmployeePosition EmployeePosition);
        Task<EmployeePosition> UpdatePositionToEmployeeAsync(int employeeId, int positionId, EmployeePosition EmployeePosition);

        Task<IEnumerable<EmployeePosition>> GetEmployeePositionsAsync(int employeeId);
        Task<bool> DeletePositionOfEmployeeAsync(int employeeId, int positionId);
    }
}
