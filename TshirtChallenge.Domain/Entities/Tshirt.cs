using FluentValidation;
using System.ComponentModel.DataAnnotations.Schema;
using TshirtChallenge.Domain.Validations;

namespace TshirtChallenge.Domain.Entities
{
    public class Tshirt : BaseEntity
    {
        public string Name { get; protected set; }
        public IEnumerable<Type> Types { get; protected set; }

        [NotMapped] 
        protected override IValidator _validator => new TshirtValidation();

        public Tshirt(string name, IEnumerable<Type> types) : base()
        {
            Name = name;
            Types = types;
        }
    }
}