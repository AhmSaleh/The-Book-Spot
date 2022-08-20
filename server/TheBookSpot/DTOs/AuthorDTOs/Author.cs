using TheBookSpot.DTOs.BookDTOs;

namespace TheBookSpot.DTOs.AuthorDTOs
{
    public class Author
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
    }
}
