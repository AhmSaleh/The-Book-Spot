using TheBookSpotDomain.Base;
using TheBookSpotDomain.BookEnums;
using TheBookSpotDomain.ValidatorExtensions;

namespace TheBookSpotDomain.Entities
{
    public class Book : IEntityBase
    {
        public Guid Id { get; set; }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException(nameof(Title) + "Can't be null or empty.");

                _title = value;
            }
        }

        public string ISBN { get; set; }
        public BookType Type { get; set; }

        private int _publicationYea;
        public int PublicationYear
        {
            get
            {
                return _publicationYea;
            }
            set
            {
                if (!value.ValidPublicationYear())
                    throw new InvalidOperationException(nameof(PublicationYear) +
                        $" Must be Greater than 1700 and less than or equal the current year({DateTime.Now.Year})");

                _publicationYea = value;
            }
        }

        public decimal _price { get; set; }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (!value.GraterThanZero())
                {
                    throw new InvalidOperationException(nameof(Price) + "Can't be less than or equal zero.");
                }
                _price = value;
            }
        }

        public BookCondition Condition { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
