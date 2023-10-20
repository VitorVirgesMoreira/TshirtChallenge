using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Infra.Context;
using Type = TshirtChallenge.Domain.Entities.Type;

namespace TshirtChallenge.Infra.Repositories
{
    public class TypeRepository : GenericRepository<Type>, ITypeRepository
    {
        public TypeRepository(MainContext dbcontext) : base(dbcontext)
        {
        }
    }
}
