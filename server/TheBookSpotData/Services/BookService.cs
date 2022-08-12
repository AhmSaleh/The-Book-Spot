using TheBookSpotDomain;

namespace TheBookSpotData.Services
{
    public class BookService : IBookService
    {
        private readonly TheBookSpotContext _context;

        public BookService(TheBookSpotContext context)
        {
            _context = context;
        }

        public Task<List<Book>> AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBook<Book>(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Book> SelectBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBook<Book>(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
