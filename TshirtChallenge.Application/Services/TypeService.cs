using TshirtChallenge.Application.Models.TypeModel;
using TshirtChallenge.Application.Services.Interfaces;
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

            return types.Select(type => new TypeResponseModel(
                type.Color,
                type.Fabric,
                ConvertImageToBase64(type.TshirtImages.FirstOrDefault(x => x.TypeId == type.Id)?.Data)
            ));
        }

        private string? ConvertImageToBase64(byte[]? data)
        {
            return data != null ? Convert.ToBase64String(data) : null;
        }
    }
}
