using FluentValidation;

namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.Employee.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () => 
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });
        }
    }
}
