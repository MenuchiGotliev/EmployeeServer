namespace EmployeeServer.Models
{
    public enum Gender
    {
        male = 1,
        female = 2
    }
    public class EmployeePostModel
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

