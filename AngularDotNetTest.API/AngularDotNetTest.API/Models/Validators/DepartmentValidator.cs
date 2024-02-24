using AngularDotNetTest.API.Models.Dtos;
using FluentValidation;

namespace AngularDotNetTest.API.Models.Validators
{
    public class DepartmentValidator : AbstractValidator<DepartmentDto>
    {
        public DepartmentValidator()
        {
            RuleFor(d => d.Name).NotEmpty().WithMessage("Department Name is Required");
        }
    }
}
