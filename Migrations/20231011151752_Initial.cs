using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "DeckID", "DeckCount", "DeckName" },
                values: new object[,]
                {
                    { 2, 52, "Standard" },
                    { 3, 100, "another one" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "DeckID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "DeckID",
                keyValue: 3);
        }
    }
}
