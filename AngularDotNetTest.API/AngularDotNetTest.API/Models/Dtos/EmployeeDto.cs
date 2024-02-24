namespace AngularDotNetTest.API.Models.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? JobTitle { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? DepartmentName { get; set; }

        public int? DepartmentId { get; set; }

        public string? ImagePath { get; set; }

        public byte[]? ImageBytes { get; set; }
    }
}
