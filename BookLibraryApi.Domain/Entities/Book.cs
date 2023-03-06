using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Domain.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
