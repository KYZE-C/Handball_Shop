using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Variants_Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatformProduct");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Variants_Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AdditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    OriginalPrice = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants_Product", x => new { x.ProductId, x.AdditionId });
                    table.ForeignKey(
                        name: "FK_Variants_Product_Platforms_AdditionId",
                        column: x => x.AdditionId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Variants_Product_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Default" });

            migrationBuilder.InsertData(
                table: "Variants_Product",
                columns: new[] { "AdditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 6, 2, 20.0, null },
                    { 7, 2, null, 24.0 },
                    { 8, 2, null, 20.399999999999999 },
                    { 1, 5, 27.0, null },
                    { 2, 5, null, 32.399999999999999 },
                    { 3, 5, null, 32.399999999999999 },
                    { 4, 5, null, 32.399999999999999 },
                    { 5, 5, null, 32.399999999999999 },
                    { 1, 7, 69.989999999999995, null },
                    { 2, 7, null, 83.988 },
                    { 3, 7, null, 83.988 },
                    { 4, 7, null, 83.988 },
                    { 5, 7, null, 83.988 },
                    { 1, 9, 2.0, null },
                    { 2, 9, null, 2.3999999999999999 },
                    { 3, 9, null, 2.3999999999999999 },
                    { 4, 9, null, 2.3999999999999999 },
                    { 5, 9, null, 2.3999999999999999 },
                    { 1, 10, 3.0, null },
                    { 2, 10, null, 3.6000000000000001 },
                    { 3, 10, null, 3.6000000000000001 },
                    { 4, 10, null, 3.6000000000000001 },
                    { 5, 10, null, 3.6000000000000001 },
                    { 9, 1, 6.9900000000000002, null },
                    { 9, 4, 9.9900000000000002, null },
                    { 9, 6, 349.99000000000001, null },
                    { 9, 8, 3.9900000000000002, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Variants_Product_AdditionId",
                table: "Variants_Product",
                column: "AdditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants_Product");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<double>(
                name: "OriginalPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "PlatformProduct",
                columns: table => new
                {
                    PlatformsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformProduct", x => new { x.PlatformsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_PlatformProduct_Platforms_PlatformsId",
                        column: x => x.PlatformsId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatformProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 5 },
                    { 1, 7 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 3 },
                    { 2, 5 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 3 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 10 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 7 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 5.0, 5.5499999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 17.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 40.0, 32.990000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 15.0, 12.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 30.0, 25.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 120.0, 99.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 90.0, 74.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 8.0, 6.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 12.0, 9.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 10.0, 7.9900000000000002 });

            migrationBuilder.CreateIndex(
                name: "IX_PlatformProduct_ProductsId",
                table: "PlatformProduct",
                column: "ProductsId");
        }
    }
}
