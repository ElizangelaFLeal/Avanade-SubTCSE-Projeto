using Avanade_SubTCSE_Projeto.Doma.Aggregates.EmployeeRole.Validators;
using FluentValidation;

namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Avanade_SubTCSE_Projeto.Doma.Aggregates.Employee.Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");

                RuleFor(e => e.SurName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");

                RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmployeeRoleValidator());
            });
        }
    }
}
