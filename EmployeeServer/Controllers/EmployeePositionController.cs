using AutoMapper;
using EmployeeServer.Core.DTOs;
using EmployeeServer.Core.Entities;
using EmployeeServer.Core.Services;
using EmployeeServer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePositionController : ControllerBase
    {

        private readonly IEmployeePositionService _employeePositionService;
        private readonly IMapper _mapper;
        public EmployeePositionController(IEmployeePositionService employeePositionService,IMapper mapper)
        {
            _employeePositionService = employeePositionService;
            _mapper = mapper;

        }
        // GET: api/<EmployeePositionController>
        [HttpGet("{employeeId}")]
        public async Task<IEnumerable<EmployeePosition>> Get(int employeeId)
        {
            return await _employeePositionService.GetEmployeePositionsAsync(employeeId);
        }
       


        // POST api/<EmployeePositionController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePositionPostModel value)
        {
            var newEmployee = await _employeePositionService.AddPositionToEmployeeAsync(_mapper.Map<EmployeePosition>(value));
            return Ok(newEmployee);
        }

        // PUT api/<EmployeePositionController>/5
        [HttpPut("{employeeId}/position/{positionId}")]
        public async Task<ActionResult> Put(int employeeId,int positionId, [FromBody] EmployeePositionPostModel value)
        {
            var updateEmployeePosition = await _employeePositionService.UpdatePositionToEmployeeAsync(employeeId, positionId, _mapper.Map<EmployeePosition>(value));
            if (updateEmployeePosition == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EmployeePositionDto>(updateEmployeePosition));
        }

        // DELETE api/<EmployeePositionController>/5
        [HttpDelete("{employeeId}/position/{positionId}")]
        public async Task<bool> Delete(int employeeId,int positionId)
        {
          return await  _employeePositionService.DeletePositionOfEmployeeAsync(employeeId, positionId);
        }
    }
}
