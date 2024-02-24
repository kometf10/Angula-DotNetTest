using AngularDotNetTest.API.Models.Dtos;
using FluentValidation;

namespace AngularDotNetTest.API.Models.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().WithMessage("Employee Name is Required");
            RuleFor(e => e.LastName).NotEmpty().WithMessage("Employee Name is Required");

            When(e => e.DateOfBirth != null, () =>
            {
                RuleFor(e => e.DateOfBirth).LessThan(DateTime.Now.AddYears(-18))
                    .WithMessage("Invalid Date of Birth");
            });
            
        }
    }
}
