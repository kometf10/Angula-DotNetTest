using System.ComponentModel.DataAnnotations;

namespace AngularDotNetTest.API.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}
