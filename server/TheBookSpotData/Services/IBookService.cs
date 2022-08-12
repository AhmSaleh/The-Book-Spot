using TheBookSpotDomain;

namespace TheBookSpotData.Services
{
    public interface IBookService
    {
        Task<List<Book>> SelectAll();
        Task<Book> SelectBookById(int id);
        Task<List<Book>> AddBook(Book book);
        Task UpdateBook<Book>(Book book);
        Task DeleteBook<Book>(Book book);
    }
}
