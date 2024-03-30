using EmployeeServer.Core.Entities;
using EmployeeServer.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePositionController : ControllerBase
    {

        private readonly IEmployeePositionService _employeePositionService;
     
        public EmployeePositionController(IEmployeePositionService employeePositionService)
        {
            _employeePositionService = employeePositionService;
          
        }
        // GET: api/<EmployeePositionController>
        [HttpGet]
        public async Task<IEnumerable<EmployeePosition>> Get()
        {
            return await _employeePositionService.GetEmployeePositionsAsync();
            
        }

        //// GET api/<EmployeePositionController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EmployeePositionController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePosition value)
        {
            var newEmployee = await _employeePositionService.AddEmployeePositionAsync();
            return Ok(newEmployee);
        }

        // PUT api/<EmployeePositionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeePositionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
