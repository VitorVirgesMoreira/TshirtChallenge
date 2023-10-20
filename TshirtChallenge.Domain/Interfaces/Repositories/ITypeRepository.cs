using TshirtChallenge.Domain.Entities;
using Type = TshirtChallenge.Domain.Entities.Type;

namespace TshirtChallenge.Domain.Interfaces.Repositories
{
    public interface ITypeRepository : IGenericRepository<Type>
    {
        Task<IEnumerable<Type>> GetTypesByTshirtId(Guid tshirtId);
    }
}
