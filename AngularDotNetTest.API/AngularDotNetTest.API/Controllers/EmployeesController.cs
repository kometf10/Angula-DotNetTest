using AngularDotNetTest.API.Models;
using AngularDotNetTest.API.Models.Dtos;
using AngularDotNetTest.API.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AngularDotNetTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await _employeesService.Get();
            return Ok(employees);   
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeDto employee)
        {
            var createdEmployee = await _employeesService.Create(employee);
            return Ok(createdEmployee);
        }

        [HttpPut]
        public async Task<ActionResult> Update(EmployeeDto employee)
        {
            var createdEmployee = await _employeesService.Create(employee);
            return Ok(createdEmployee);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok();
        }

    }
}
