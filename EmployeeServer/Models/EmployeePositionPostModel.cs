using EmployeeServer.Core.Entities;

namespace EmployeeServer.Models
{
    public class EmployeePositionPostModel
    {
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public DateTime EntryDate { get; set; }
        public Employee Employee { get; set; }
        public Position Position { get; set; }
    }
}
