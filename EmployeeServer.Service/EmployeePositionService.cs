﻿using EmployeeServer.Core.Entities;
using EmployeeServer.Core.Repositories;
using EmployeeServer.Core.Services;
using EmployeeServer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Service
{
    public class EmployeePositionService:IEmployeePositionService
    {
        private readonly IEmployeePositionRepository _employeePositionRepository;
        public EmployeePositionService(IEmployeePositionRepository employeePositionRepository)
        {
            _employeePositionRepository = employeePositionRepository;
        }
        public async Task<EmployeePosition> AddPositionToEmployeeAsync(EmployeePosition EmployeePosition)
        {
            return await _employeePositionRepository.AddPositionToEmployeeAsync(EmployeePosition);
        }
        public async Task<EmployeePosition> UpdatePositionToEmployeeAsync(int empoyeeId, int positionId, EmployeePosition EmployeePosition)
        {
            return await _employeePositionRepository.UpdatePositionToEmployeeAsync(empoyeeId, positionId, EmployeePosition);    
        }

        public async Task<bool> DeletePositionOfEmployeeAsync(int employeeId, int positionId)
        {
           return await _employeePositionRepository.DeletePositionOfEmployeeAsync(employeeId, positionId);
        }
        public async Task<IEnumerable<EmployeePosition>> GetEmployeePositionsAsync(int employeeId)
        {
            return await _employeePositionRepository.GetEmployeePositionsAsync(employeeId);
        }


    }
}
