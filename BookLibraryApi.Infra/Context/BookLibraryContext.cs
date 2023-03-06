using BookLibraryApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryApi.Infra.Context
{
    public class BookLibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BookLibrary;Integrated Security=True");
        }
    }
}
