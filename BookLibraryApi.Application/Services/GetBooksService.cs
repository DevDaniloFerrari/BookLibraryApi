using BookLibraryApi.Domain.Entities;
using BookLibraryApi.Domain.Repositories;
using BookLibraryApi.Domain.Services;

namespace BookLibraryApi.Application.Services
{
    public class GetBooksService : IGetBooksService
    {
        private readonly IBookRepository _bookRepository;

        public GetBooksService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> { new Book { Title = "test" } };
        }
    }
}
