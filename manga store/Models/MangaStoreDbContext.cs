using Microsoft.EntityFrameworkCore;

namespace manga_store.Models
{
    public class MangaStoreDbContext : DbContext
    {
        public MangaStoreDbContext(DbContextOptions<MangaStoreDbContext> options)
        : base(options) { }
        public DbSet<Mangas> Mangas { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}