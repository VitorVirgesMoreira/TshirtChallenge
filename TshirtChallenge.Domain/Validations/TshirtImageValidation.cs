using FluentValidation;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Domain.Validations
{
    public class TshirtImageValidation : AbstractValidator<TshirtImage>
    {
        public TshirtImageValidation()
        {
            RuleFor(x => x.ImagePath)
                .NotEmpty().WithMessage("Image Path should be informed.");

            RuleFor(x => x.Type)
                .Must(x => x != null)
                .WithMessage("Type should be informed.");
        }
    }
}
