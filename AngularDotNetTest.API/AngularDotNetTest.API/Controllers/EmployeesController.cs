using AngularDotNetTest.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularDotNetTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "KOKO", LastName = "FOFO", JobTitle = "Full-Stack Developer"},
                new Employee { Id = 2, FirstName = "ZOZO", LastName = "KOKO", JobTitle = "Front-End Developer"},
            };

            for (int i = 1; i < 11; i++)
                employees.Add(new Employee { Id = i, FirstName = $"Test Employee F{i}", LastName = $"Test Employee L{i}", JobTitle = $"Test Employee J{i}" });
            

            return Ok(employees);   
        }
    }
}
