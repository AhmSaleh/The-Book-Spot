using TheBookSpotDomain;

namespace TheBookSpotData.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly TheBookSpotContext _context;

        public AuthorService(TheBookSpotContext context)
        {
            _context = context;
        }

        public Task AddAuthor<Author>()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAuthor<Author>(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<List<Author>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Author> SelectAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAuthor<Author>(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
