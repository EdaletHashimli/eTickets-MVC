using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly eTicketDbContext _context;
        public EntityBaseRepository(eTicketDbContext context) 
        {
            _context = context;
        }
        public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        
        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        

        public Task<T> UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }

    }
}
