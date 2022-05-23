using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using manga_store.Models;

namespace manga_store.Data
{
    public class manga_storeContext : DbContext
    {
        public manga_storeContext (DbContextOptions<manga_storeContext> options)
            : base(options)
        {
        }

        public DbSet<manga_store.Models.Manga> Manga { get; set; }
    }
}
