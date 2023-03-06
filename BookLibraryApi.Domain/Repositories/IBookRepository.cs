using BookLibraryApi.Domain.Entities;

namespace BookLibraryApi.Domain.Repositories
{
    public interface IBookRepository
    {
        public IQueryable<Book> GetBooks();
    }
}
