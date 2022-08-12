using TheBookSpotDomain;

namespace TheBookSpotData.Services
{
    public interface IAuthorService
    {
        Task<List<Author>> SelectAll();
        Task<Author> SelectAuthorById(int id);
        Task AddAuthor<Author>();
        Task UpdateAuthor<Author>(Author author);
        Task DeleteAuthor<Author>(Author author);
    }
}
