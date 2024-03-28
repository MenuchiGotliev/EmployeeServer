using EmployeeServer.Core.Entities;
using EmployeeServer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Service
{
    public class PositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public async Task<Position> AddAsync(Position position)
        {
            await _positionRepository.AddAsync(position);
        }

        public async Task DeleteAsync(int id)
        {
            await _positionRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Position>> GetAllAsync()
        {
            return await _positionRepository.GetAllAsync();
        }

        public async Task<Position> GetByIdAsync(int id)
        {
            return await _positionRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync( Position position)
        {
             await _positionRepository.UpdateAsync( position);
        }
    }
}
