using FluentValidation;
using Type = TshirtChallenge.Domain.Entities.Type;

namespace TshirtChallenge.Domain.Validations
{
    public class TypeValidation : AbstractValidator<Type>
    {
        public TypeValidation()
        {
            RuleFor(x => x.Color)
                .NotEmpty().WithMessage("Color should be informed.");

            RuleFor(x => x.Fabric)
                .NotEmpty().WithMessage("Fabric should be informed.");
        }
    }
}
