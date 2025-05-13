using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATA.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClientTableFieldAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FinancialEmailList",
                schema: "Bluebook",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarketingEmailList",
                schema: "Bluebook",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinancialEmailList",
                schema: "Bluebook",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "MarketingEmailList",
                schema: "Bluebook",
                table: "Client");
        }
    }
}
