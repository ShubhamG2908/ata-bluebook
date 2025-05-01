using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATA.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClientTableChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactType",
                schema: "Bluebook",
                table: "Client",
                newName: "ContractType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContractType",
                schema: "Bluebook",
                table: "Client",
                newName: "ContactType");
        }
    }
}
