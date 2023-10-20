using TshirtChallenge.Application.Models.ImageModel;

namespace TshirtChallenge.Application.Services.Interfaces
{
    public interface IImageService
    {
        Task Create(ImageRequestModel requestModel);
        Task Delete(Guid id);
    }
}
