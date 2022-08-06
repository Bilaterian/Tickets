
using Microsoft.EntityFrameworkCore;

namespace Tickets.Data
{
    public class TicketsDbContext: DbContext
    {
        public TicketsDbContext(DbContextOptions<TicketsDbContext> options) :base(options)
        {

        }
    }
}
