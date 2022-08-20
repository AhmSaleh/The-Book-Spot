using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TheBookSpotData.Base;
using TheBookSpotDomain.Entities;

namespace TheBookSpotData.Services.AuthorSevices
{
    public class AuthorService : EntityBaseReposiotry<Author>, IAuthorService
    {
        public AuthorService(TheBookSpotContext context) : base(context)
        {
        }

        override public async Task<Author> UpdateAsync(Guid id, Author entity)
        {
            var existingEntity = await GetAsync(id);

            if (existingEntity == null)
                return null;

            existingEntity.FirstName = entity.FirstName;
            existingEntity.LastName = entity.LastName;

            EntityEntry entityEntry = _context.Entry(existingEntity);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return existingEntity;
        }

    }
}
