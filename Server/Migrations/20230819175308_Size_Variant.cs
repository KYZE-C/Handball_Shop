using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Size_Variant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 2, 5 },
                    { 2, 7 },
                    { 2, 9 },
                    { 3, 3 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 9 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 9 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 7 },
                    { 5, 9 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 9 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 5 },
                    { 7, 7 },
                    { 7, 9 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 7 },
                    { 8, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "XS");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "S");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "L");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "XL");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 2 });

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
                keyValues: new object[] { 7, 2 });

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
                keyValues: new object[] { 8, 2 });

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

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 1, 10 },
                    { 2, 8 },
                    { 3, 8 },
                    { 4, 8 },
                    { 5, 8 },
                    { 6, 8 },
                    { 7, 8 },
                    { 8, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Yellow");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Red");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Blue");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Green");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Orange");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Purple");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Pink");

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Brown");

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "White" },
                    { 10, "Black" },
                    { 11, "Gray" }
                });

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 9, 8 },
                    { 9, 10 },
                    { 10, 8 },
                    { 10, 10 },
                    { 11, 8 },
                    { 11, 10 }
                });
        }
    }
}
