using EmployeeServer.Core.Entities;

namespace EmployeeServer.Models
{
    public class EmployeePositionPostModel
    {
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsManager { get; set; }
    }
}
