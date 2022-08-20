using TheBookSpotDomain.Base;

namespace TheBookSpotData.Base
{
    public interface IEntityBaseReposiotry<T> where T : class, IEntityBase, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task<T> AddAsync(T author);
        Task<T> UpdateAsync(Guid id, T author);
        Task<T> DeleteAsync(Guid id);
    }
}
