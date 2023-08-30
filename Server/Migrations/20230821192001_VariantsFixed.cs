using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class VariantsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 1 },
                column: "Price",
                value: 6.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 6, 2 },
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 3 },
                column: "Price",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 4 },
                column: "Price",
                value: 9.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 5 },
                column: "Price",
                value: 27.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 6 },
                column: "Price",
                value: 349.99000000000001);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 7 },
                column: "Price",
                value: 69.989999999999995);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 8 },
                column: "Price",
                value: 3.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 9 },
                column: "Price",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 10 },
                column: "Price",
                value: 3.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 1 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 6, 2 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 3 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 4 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 5 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 6 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 7 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 8 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 9 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 10 },
                column: "Price",
                value: null);
        }
    }
}
