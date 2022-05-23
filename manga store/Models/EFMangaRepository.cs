using System.Linq;

namespace manga_store.Models
{
     public class EFMangaStoreRepository : IMangaStoreRepository
    {
        private MangaStoreDbContext context;
        public EFMangaStoreRepository(MangaStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Mangas> Books => context.Mangas;
    }
}