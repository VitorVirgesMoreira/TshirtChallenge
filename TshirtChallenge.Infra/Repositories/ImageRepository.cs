using TshirtChallenge.Domain.Entities;
using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Infra.Context;
using TshirtChallenge.Infra.Repositories;

namespace TshirtChallenge.Infra.Repositories
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(MainContext dbcontext) : base(dbcontext)
        {
        }
    }
}
