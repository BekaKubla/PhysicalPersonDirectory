using FluentValidation;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;

namespace PhysicalPersonDirectory.Application.Validators.PersonValidator
{
    public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonCommandValidator()
        {
            RuleFor(e => e.person.NameEn).NotNull();
        }
    }
}
