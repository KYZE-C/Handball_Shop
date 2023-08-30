using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Variant_Size : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 5 },
                    { 1, 7 },
                    { 1, 9 },
                    { 1, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 10 });
        }
    }
}
