using FluentValidation;
using System.ComponentModel.DataAnnotations.Schema;
using TshirtChallenge.Domain.Validations;

namespace TshirtChallenge.Domain.Entities
{
    public class Type : BaseEntity
    {
        public string Color { get; protected set; }
        public string Fabric { get; protected set; }
        public Guid TshirtId { get; set; }
        public Tshirt Tshirt { get; set; }
        public List<Image> TshirtImages { get; set; }

        [NotMapped]
        protected override IValidator _validator => new TypeValidation();

        public Type(string color, string fabric, Guid tshirtId) : base()
        {
            Color = color;
            Fabric = fabric;
            TshirtId = tshirtId;
        }
    }
}
