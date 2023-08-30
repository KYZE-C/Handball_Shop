using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Size_Variant_Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 10 },
                    { 7, 3 },
                    { 7, 5 },
                    { 7, 7 },
                    { 7, 9 },
                    { 7, 10 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 7 },
                    { 8, 9 },
                    { 8, 10 }
                });
        }
    }
}
