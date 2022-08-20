using TheBookSpotDomain.BookEnums;

namespace TheBookSpot.DTOs.AuthorDTOs
{
    public class AddBookRequest
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public BookType Type { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
        public BookCondition Condition { get; set; }
        public Guid AuthorId { get; set; }
    }
}
