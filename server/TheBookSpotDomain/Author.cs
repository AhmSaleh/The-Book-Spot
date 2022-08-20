
using TheBookSpotData.Base;

namespace TheBookSpotDomain
{
    public class Author : IEntityBase
    {
        public Author()
        {
            Books = new();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
    }
}
