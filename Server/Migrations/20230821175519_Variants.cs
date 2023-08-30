using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Variants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Variants_Product",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OriginalPrice",
                table: "Variants_Product",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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
                keyValues: new object[] { 7, 2 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 8, 2 },
                column: "OriginalPrice",
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
                keyValues: new object[] { 2, 3 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 3 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 3 },
                column: "OriginalPrice",
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
                keyValues: new object[] { 2, 5 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 5 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 5 },
                column: "OriginalPrice",
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
                keyValues: new object[] { 2, 7 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 7 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 7 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 7 },
                column: "OriginalPrice",
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
                keyValues: new object[] { 2, 9 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 9 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 9 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 9 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 10 },
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 10 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 10 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 10 },
                column: "OriginalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 10 },
                column: "OriginalPrice",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Variants_Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OriginalPrice",
                table: "Variants_Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 1 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 6, 2 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 7, 2 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 8, 2 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 3 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 3 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 3 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 4 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 5 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 5 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 5 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 5 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 6 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 7 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 7 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 7 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 7 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 7 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 9, 8 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 9 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 9 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 9 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 9 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 9 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 1, 10 },
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 2, 10 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 3, 10 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 4, 10 },
                column: "OriginalPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Variants_Product",
                keyColumns: new[] { "AdditionId", "ProductId" },
                keyValues: new object[] { 5, 10 },
                column: "OriginalPrice",
                value: 0.0);
        }
    }
}
