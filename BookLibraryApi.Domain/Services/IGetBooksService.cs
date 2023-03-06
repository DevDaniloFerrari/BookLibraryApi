using BookLibraryApi.Domain.Entities;

namespace BookLibraryApi.Domain.Services
{
    public interface IGetBooksService
    {
        public IEnumerable<Book> GetBooks();
    }
}
