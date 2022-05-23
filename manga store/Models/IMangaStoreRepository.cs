using System.Linq;
namespace manga_store.Models
{
    public interface IMangaStoreRepository    {
        IQueryable<Mangas> Manga { get; }
    }
}