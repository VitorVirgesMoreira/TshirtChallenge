using TshirtChallenge.Application.Models.TypeModel;

namespace TshirtChallenge.Application.Services.Interfaces
{
    public interface ITypeService
    {
        Task<IEnumerable<TypeResponseModel>> GetTypesByTshirtId(Guid tshirtId);
    }
}
