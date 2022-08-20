using TheBookSpotDomain.BookEnums;

namespace TheBookSpot.DTOs.BookDTOs
{
    public class UpdateBookResponse
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
