using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System.Data;
using TheBookSpotData.Base;
using TheBookSpotDomain.Entities;

namespace TheBookSpotData.Services.AuthorSevices
{
    public class AuthorService : EntityBaseReposiotry<Author>, IAuthorService
    {
        private IDbConnection DapperDBConnection;

        public AuthorService(TheBookSpotContext context, IConfiguration config) : base(context)
        {
            DapperDBConnection = new SqlConnection(config.GetConnectionString("BookSpotConnection"));
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

        override public async Task<Author> DeleteAsync(Guid id)
        {
            return await DapperDBConnection.QueryFirstOrDefaultAsync<Author>("REMOVE_AUTOR_PROC", new { Id = id }, commandType: CommandType.StoredProcedure);
        }

    }
}
