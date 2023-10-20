using TshirtChallenge.Application.Models.TshirtModel;
using TshirtChallenge.Application.Services.Interfaces;
using TshirtChallenge.Domain.Interfaces.Repositories;

namespace TshirtChallenge.Application.Services
{
    public class TshirtService : ITshirtService
    {
        private readonly ITshirtRepository _tshirtRepository;
        public TshirtService(ITshirtRepository tshirtRepository)
        {
            _tshirtRepository = tshirtRepository;
        }

        public async Task<IEnumerable<TshirtResponseModel>> GetAll()
        {
            var tshirts = await _tshirtRepository.GetAllWithIncludes();

            return tshirts.Select(tshirt => new TshirtResponseModel(
                tshirt.Id,
                tshirt.Name,
                tshirt.Types.Sum(type => type.Color != null ? 1 : 0),
                tshirt.Types.Sum(type => type.Fabric != null ? 1 : 0),
                tshirt.Types.Select(type => type.TshirtImages.Count()).FirstOrDefault()
            ));
        }
    }
}
