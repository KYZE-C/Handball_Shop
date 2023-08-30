using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class WorkingOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Platfrom_sizeProduct");

            migrationBuilder.DropTable(
                name: "Platfroms_size");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platfroms_size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platfroms_size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platfrom_sizeProduct",
                columns: table => new
                {
                    Platforms_sizeId = table.Column<int>(type: "int", nullable: false),
                    Products_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platfrom_sizeProduct", x => new { x.Platforms_sizeId, x.Products_Id });
                    table.ForeignKey(
                        name: "FK_Platfrom_sizeProduct_Platfroms_size_Platforms_sizeId",
                        column: x => x.Platforms_sizeId,
                        principalTable: "Platfroms_size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Platfrom_sizeProduct_Products_Products_Id",
                        column: x => x.Products_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Platfrom_sizeProduct_Products_Id",
                table: "Platfrom_sizeProduct",
                column: "Products_Id");
        }
    }
}
