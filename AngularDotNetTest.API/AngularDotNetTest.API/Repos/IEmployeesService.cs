using AngularDotNetTest.API.Models;
using AngularDotNetTest.API.Models.Dtos;

namespace AngularDotNetTest.API.Repos
{
    public interface IEmployeesService
    {
        Task<EmployeeDto> Create(EmployeeDto employee);
        Task<IEnumerable<EmployeeDto>> Get();
        
    }
}
