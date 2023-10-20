using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Type>> GetTypesByTshirtId(Guid tshirtId)
        {
            return await Query()
                            .Include(x => x.TshirtImages)
                            .Where(x => x.TshirtId == tshirtId)
                            .ToListAsync();
        }
    }
}
