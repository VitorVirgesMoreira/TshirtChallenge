using FluentValidation;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Domain.Validations
{
    public class ImageValidation : AbstractValidator<Image>
    {
        public ImageValidation()
        {
            RuleFor(x => x.Data)
                .NotEmpty().WithMessage("Image Path should be informed.");
        }
    }
}
