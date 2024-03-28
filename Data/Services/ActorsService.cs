using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly eTicketDbContext _context;

        public ActorsService(eTicketDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
             await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Actor actor)
        {
            var _actor = await _context.Actors.FindAsync(actor.ActorId);
            if (_actor != null)
            {
                _context.Actors.Remove(_actor); // _actor dəyişənini istifadə edin, actor dəyişənini deyil
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }
        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
