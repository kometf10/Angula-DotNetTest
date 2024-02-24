using AngularDotNetTest.API.Data;
using AngularDotNetTest.API.Models;
using AngularDotNetTest.API.Models.Dtos;
using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace AngularDotNetTest.API.Repos
{
    public class EmployeesService : IEmployeesService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public EmployeesService(AppDbContext dbContext, IMapper mapper, IConfiguration config)
        {         
            _dbContext = dbContext;
            _mapper = mapper;
            _config = config;
        }

        public async Task<EmployeeDto> Create(EmployeeDto employeeDto)
        {
            var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            int employeeId = connection.QuerySingle<int>(
                "CreateEmployee",
                new
                {
                    FirstName = employeeDto.FirstName,
                    LastName = employeeDto.LastName,
                    JobTitle = employeeDto.JobTitle,
                    BirthDate = employeeDto.DateOfBirth,
                    DepartmentId = employeeDto.DepartmentId,
                },
                commandType: CommandType.StoredProcedure
            );

            var createdEmployee = await Get(employeeId);

            return createdEmployee;
        }

        public async Task<EmployeeDto> Get(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));

            var employees = await connection.QueryAsync<Employee>("Select * From TestDB.dbo.Employees");

            var employeeDtos = _mapper.Map<List<EmployeeDto>>(employees);

            return employeeDtos;
        }
    }
}
