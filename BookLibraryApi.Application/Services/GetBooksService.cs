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

        public IEnumerable<Book> GetBooks(string property = null, string value = null)
        {
            var query = _bookRepository.GetBooks();

            if (property != null)
                return query.Where(book => ((string)book[property]).Contains(value));

            return query;
        }
    }
}
