using Moviekart.Models;

namespace Moviekart.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);
        void Add(T entity);
        Task<T> Update(int id, T entity);
        Task Delete(int id);
    }
}
