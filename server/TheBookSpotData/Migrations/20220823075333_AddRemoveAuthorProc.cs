using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookSpotData.Migrations
{
    public partial class AddRemoveAuthorProc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE REMOVE_AUTOR_PROC
                (@Id UNIQUEIDENTIFIER)
                AS
                BEGIN
	                SELECT * FROM Authors
	                WHERE Id = @Id
 
	                DELETE FROM Authors
	                WHERE Id = @Id 
                END"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DROP PROCEDURE REMOVE_AUTOR_PROC"
             );
        }
    }
}
