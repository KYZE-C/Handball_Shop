using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Variants_Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Variants_Product",
                columns: new[] { "AdditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 3, null, 20.399999999999999 },
                    { 2, 3, null, 20.399999999999999 },
                    { 3, 3, null, 20.399999999999999 },
                    { 4, 3, null, 20.399999999999999 },
                    { 5, 3, null, 20.399999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 3 });
        }
    }
}
