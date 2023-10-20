using Microsoft.AspNetCore.Http;

namespace TshirtChallenge.Application.Models.ImageModel
{
    public class ImageRequestModel
    {
        public IFormFile ImageFile { get; set; }
        public Guid TypeId { get; set; }
    }
}
