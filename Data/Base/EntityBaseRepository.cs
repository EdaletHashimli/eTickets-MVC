using eTickets.Models;

namespace eTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
