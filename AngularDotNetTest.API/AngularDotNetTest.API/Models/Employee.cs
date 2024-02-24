using System.ComponentModel.DataAnnotations;

namespace AngularDotNetTest.API.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? JobTitle { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Department? Department { get; set; }

        public int? DepartmentId { get; set; }

        public string? Image { get; set; }
    }
}
