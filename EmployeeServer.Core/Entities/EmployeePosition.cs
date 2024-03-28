using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Core.Entities
{
    public class EmployeePosition
    {
      
            public int EmployeeId { get; set; }
            public int PositionId { get; set; }
            public DateTime EntryDate { get; set; }
            public Employee Employee { get; set; }
            public Position Position { get; set; }
        

    }
}
