using TshirtChallenge.Domain.Entities;
using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Infra.Context;
using TshirtChallenge.Infra.Repositories;

namespace TshirtChallenge.Infra.Repositories
{
    public class TshirtRepository : GenericRepository<Tshirt>, ITshirtRepository
    {
        public TshirtRepository(MainContext dbcontext) : base(dbcontext)
        {
        }
    }
}
