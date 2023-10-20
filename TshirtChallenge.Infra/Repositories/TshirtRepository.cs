using TshirtChallenge.Domain.Entities;
using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Repository.Context;
using TshirtChallenge.Repository.Repositories;

namespace TshirtChallenge.Infra.Repositories
{
    public class TshirtRepository : GenericRepository<Tshirt>, ITshirtRepository
    {
        public TshirtRepository(MainContext dbcontext) : base(dbcontext)
        {
        }
    }
}
