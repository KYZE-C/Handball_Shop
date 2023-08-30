using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class ColorBox_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Products",
                newName: "SizeOfPreview");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Products",
                newName: "ColorOfPreview");

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Yellow" },
                    { 2, "Red" },
                    { 3, "Blue" },
                    { 4, "Green" },
                    { 5, "Orange" },
                    { 6, "Purple" },
                    { 7, "Pink" },
                    { 8, "Brown" },
                    { 9, "White" },
                    { 10, "Black" },
                    { 11, "Gray" },
                    { 12, "XS" },
                    { 13, "S" },
                    { 14, "M" },
                    { 15, "L" },
                    { 16, "XL" },
                    { 17, "XXL" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ColorOfPreview",
                value: "Black");

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 1, 10 },
                    { 2, 8 },
                    { 2, 10 },
                    { 3, 8 },
                    { 3, 10 },
                    { 4, 8 },
                    { 4, 10 },
                    { 5, 8 },
                    { 5, 10 },
                    { 6, 8 },
                    { 6, 10 },
                    { 7, 8 },
                    { 7, 10 },
                    { 8, 8 },
                    { 8, 10 },
                    { 9, 8 },
                    { 9, 10 },
                    { 10, 8 },
                    { 10, 10 },
                    { 11, 8 },
                    { 11, 10 },
                    { 12, 8 },
                    { 12, 10 },
                    { 13, 8 },
                    { 13, 10 },
                    { 14, 8 },
                    { 14, 10 },
                    { 15, 8 },
                    { 15, 10 },
                    { 16, 8 },
                    { 16, 10 },
                    { 17, 8 },
                    { 17, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 10 });

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
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8);

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

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.RenameColumn(
                name: "SizeOfPreview",
                table: "Products",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "ColorOfPreview",
                table: "Products",
                newName: "Color");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Color",
                value: "Yellow");
        }
    }
}
