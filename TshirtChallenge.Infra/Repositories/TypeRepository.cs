using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Repository.Context;
using TshirtChallenge.Repository.Repositories;
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
