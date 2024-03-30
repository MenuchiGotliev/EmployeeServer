using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Core.DTOs
{
    internal class PositionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsManager { get; set; }
    }
}
