using System.Data.Entity;

namespace gameStore.Models.Rerository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}   