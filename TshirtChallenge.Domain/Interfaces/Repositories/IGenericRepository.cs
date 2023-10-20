using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> Create(T entity);
        void Update(T entity);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task Save();
    }
}
