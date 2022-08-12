using TheBookSpotDomain.BookEnums;

namespace TheBookSpotDomain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public BookType Type { get; set; }
        public DateTime PublicationYear { get; set; }
        public decimal price { get; set; }
        public BookCondition Condition { get; set; }
    }
}
