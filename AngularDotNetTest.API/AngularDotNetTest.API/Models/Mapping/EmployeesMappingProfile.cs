using AngularDotNetTest.API.Models.Dtos;
using AutoMapper;

namespace AngularDotNetTest.API.Models.Mapping
{
    public class EmployeesMappingProfile : Profile
    {
        public EmployeesMappingProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(e => e.DepartmentName, opt => opt.MapFrom(src => src.Department!.Name));

            CreateMap<EmployeeDto, Employee>()
                .ForMember(e => e.Department, opt => opt.Ignore());
        }
    }
}
