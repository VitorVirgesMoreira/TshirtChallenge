using Microsoft.EntityFrameworkCore;
using TshirtChallenge.Domain.Entities;
using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Infra.Context;

namespace TshirtChallenge.Infra.Repositories
{
    public class TshirtRepository : GenericRepository<Tshirt>, ITshirtRepository
    {
        public TshirtRepository(MainContext dbcontext) : base(dbcontext)
        {
        }

        public async Task<IEnumerable<Tshirt>> GetAllWithIncludes()
        {
            return await Query()
                            .Include(x => x.Types.Where(y => !y.Deleted))
                            .ThenInclude(x => x.Images.Where(y => !y.Deleted))
                            .ToListAsync();
        }
    }
}
