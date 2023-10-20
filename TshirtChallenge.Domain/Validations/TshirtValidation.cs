using FluentValidation;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Domain.Validations
{
    public class TshirtValidation : AbstractValidator<Tshirt>
    {
        public TshirtValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name should be informed.")
                .MaximumLength(100).WithMessage("The name must contain a maximum of 100 characters.");
        }
    }
}
