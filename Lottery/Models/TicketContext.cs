using Microsoft.EntityFrameworkCore;

namespace Lottery.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        
        public DbSet<Line> Lines { get; set; }
    }
}