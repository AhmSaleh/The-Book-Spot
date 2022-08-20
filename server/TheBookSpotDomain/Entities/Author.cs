using TheBookSpotDomain.Base;
using TheBookSpotDomain.Validators;

namespace TheBookSpotDomain.Entities
{
    public class Author : IEntityBase
    {
        public Author()
        {
            Books = new();
        }
        public Guid Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!value.ContainsCharsOnly())
                    throw new InvalidOperationException("First Name can only contains alphapet characters");

                _firstName = value;
            }

        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!value.ContainsCharsOnly())
                    throw new InvalidOperationException("Last Name can only contains alphapet characters");

                _lastName = value;
            }
        }

        public List<Book> Books { get; set; }
    }
}
