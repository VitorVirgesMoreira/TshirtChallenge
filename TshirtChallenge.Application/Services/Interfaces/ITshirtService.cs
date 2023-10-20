using TshirtChallenge.Application.Models.TshirtModel;

namespace TshirtChallenge.Application.Services.Interfaces
{
    public interface ITshirtService
    {
        Task<IEnumerable<TshirtResponseModel>> GetAll();
    }
}
