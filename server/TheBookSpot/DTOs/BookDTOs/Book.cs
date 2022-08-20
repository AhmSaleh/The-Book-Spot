using TheBookSpot.DTOs.AuthorDTOs;
using TheBookSpotDomain.BookEnums;

namespace TheBookSpot.DTOs.BookDTOs
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public BookType Type { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
        public BookCondition Condition { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
