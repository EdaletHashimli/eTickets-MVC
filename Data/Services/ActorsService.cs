using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly eTicketDbContext _context;

        public ActorsService(eTicketDbContext context): base(context) { }
    }
}
