using FluentValidation;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Domain.Validations
{
    public class TshirtImageValidation : AbstractValidator<Image>
    {
        public TshirtImageValidation()
        {
            RuleFor(x => x.Data)
                .NotEmpty().WithMessage("Image Path should be informed.");
        }
    }
}
