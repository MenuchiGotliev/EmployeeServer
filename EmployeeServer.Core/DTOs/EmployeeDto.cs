using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServer.Core.DTOs
{
    public enum Gender
    {
        male = 1,
        female = 2
    }
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public bool EmployeeStatus { get; set; }
    }
}
