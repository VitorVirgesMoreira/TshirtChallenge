using FluentValidation;
using System.ComponentModel.DataAnnotations.Schema;
using TshirtChallenge.Domain.Validations;

namespace TshirtChallenge.Domain.Entities
{
    public class Image : BaseEntity
    {
        public byte[] Data { get; set; }
        public Guid TypeId { get; set; }
        public virtual Type Type { get; set; }

        [NotMapped]
        protected override IValidator _validator => new TshirtImageValidation();

        public Image(byte[] data, Guid typeId) : base()
        {
            Data = data;
            TypeId = typeId;
        }
    }
}
