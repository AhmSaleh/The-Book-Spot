using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TheBookSpotData.Base;
using TheBookSpotDomain;

namespace TheBookSpotData.Services.BookServices
{
    public class BookService : EntityBaseReposiotry<Book>, IBookService
    {
        public BookService(TheBookSpotContext context) : base(context)
        {

        }
        override public async Task<Book> UpdateAsync(Guid id, Book book)
        {
            var existingBook = await GetAsync(id);

            if (existingBook == null)
                return null;

            existingBook.Title = book.Title;
            existingBook.ISBN = book.ISBN;
            existingBook.Type = book.Type;
            existingBook.PublicationYear = book.PublicationYear;
            existingBook.price = book.price;
            existingBook.Condition = book.Condition;
            existingBook.AuthorId = book.AuthorId;

            EntityEntry entityEntry = _context.Entry(existingBook);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return existingBook;
        }

    }
}
