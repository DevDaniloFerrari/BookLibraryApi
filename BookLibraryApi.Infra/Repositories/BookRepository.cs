using BookLibraryApi.Domain.Entities;
using BookLibraryApi.Domain.Repositories;
using BookLibraryApi.Infra.Context;

namespace BookLibraryApi.Infra.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookLibraryContext _context;

        public BookRepository(BookLibraryContext context)
        {
            _context = context;
        }

        public IQueryable<Book> GetBooks()
        {

            var query = from books in _context.Books
                        select books;

            return query;
        }
    }
}
