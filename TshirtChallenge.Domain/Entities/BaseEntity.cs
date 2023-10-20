using FluentValidation;
using TshirtChallenge.Domain.Validations;

namespace TshirtChallenge.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedAt { get; protected set; }
        public DateTime CreatedAt { get; private set; }
        protected abstract IValidator _validator { get; }

        public void Delete() => Deleted = true;

        public void ValidateEntity()
        {
            var validatorContext = new ValidationContext<object>(this);
            FluentValidation.Results.ValidationResult result = _validator.Validate(validatorContext);
            result.HandleValidationResult();
        }

        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
