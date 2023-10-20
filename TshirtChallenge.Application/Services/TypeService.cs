using TshirtChallenge.Application.Models.ImageModel;
using TshirtChallenge.Application.Models.TypeModel;
using TshirtChallenge.Application.Services.Interfaces;
using TshirtChallenge.Domain.Entities;
using TshirtChallenge.Domain.Interfaces.Repositories;

namespace TshirtChallenge.Application.Services
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;
        public TypeService(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public async Task<IEnumerable<TypeResponseModel>> GetTypesByTshirtId(Guid tshirtId)
        {
            var types = await _typeRepository.GetTypesByTshirtId(tshirtId);

            return types.Select(type =>
            {
                return new TypeResponseModel(
                    type.Id,
                    type.Color,
                    type.Fabric,
                    GetImageResponseModelList(type.Images)
                );
            });
        }

        private List<ImageResponseModel> GetImageResponseModelList(List<Image> images)
        {
            return images.Select(image => new ImageResponseModel(image.Id, ConvertImageToBase64(image.Data))).ToList();
        }

        private string? ConvertImageToBase64(byte[] data) => data != null ? Convert.ToBase64String(data) : null;
    }
}
