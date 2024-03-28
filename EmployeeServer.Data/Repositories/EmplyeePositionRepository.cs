using EmployeeServer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Data.Repositories
{
    public class EmplyeePositionRepository
    {
        private readonly DataContext _context;
        public EmplyeePositionRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<EmployeePosition> AddPositionToEmployeeAsync(EmployeePosition EmployeePosition)
        {
            await _context.EmployeePositions.AddAsync(EmployeePosition);
            _context.SaveChanges();
            return EmployeePosition;
        }
        public async Task<EmployeePosition> UpdatePositionToEmployeeAsync(int empoyeeId, int positionId, EmployeePosition EmployeePosition)
        {
            var position = await _context.EmployeePositions.FirstOrDefaultAsync(e => e.PositionId == positionId && e.EmployeeId == empoyeeId);
            if (position == null)
            {
                return null;
            }
            
            position.EntryDate = EmployeePosition.EntryDate;
            await _context.SaveChangesAsync();
            return position;
        }

        public async Task<bool> DeletePositionOfEmployeeAsync(int employeeId, int positionId)
        {
            var EmployeePosition = await _context.EmployeePositions.FirstOrDefaultAsync(e => e.EmployeeId == employeeId && e.PositionId == positionId);

            if (EmployeePosition != null)
            {
               
                await _context.SaveChangesAsync();
                return true; 
            }

            return false; 
        }
        public async Task<IEnumerable<EmployeePosition>> GetEmployeePositionsAsync(int employeeId)
        {
            return await _context.EmployeePositions.Where(e => e.EmployeeId == employeeId).ToListAsync();
        }


    }
}
