using BookLibraryApi.Domain.Entities;

namespace BookLibraryApi.Domain.Services
{
    public interface IGetBooksService
    {
        public IEnumerable<Book> GetBooks(string property = null, string value = null);
    }
}
