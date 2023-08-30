using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Handball_Shopv1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "basketball", "Equipment", "equipment" },
                    { 2, "tshirt", "Sportswear", "clothes" },
                    { 3, "shoe-prints", "Footwear", "Footwear" },
                    { 4, "headphones", "Accessories", "accessories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "DateCreated", "DateUpdated", "Demensions", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Quality", "Size", "Title" },
                values: new object[,]
                {
                    { 1, 4, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9102), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A sticky substance applied to the hands or ball to help provide grip when catching a ball", "https://contents.mediadecathlon.com/p974581/k$5043e312a6d703b0fbbeee605bb2c18e/handball-200-ml-resin-white.jpg?&f=800x800", false, false, 5.0, 5.5499999999999998, null, null, "Resin" },
                    { 2, 1, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9138), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A ball used in the sport of handball, the ball comes in different sizes ranging from 1 to 3 where 1 is for individuals aged below 9, where 2 is for 9-16, and 3 is for ages 16+", "https://th.bing.com/th/id/OIP.MWZvNTIlLKSKX-GA1fxD1wHaJ2?w=149&h=195&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 17.0, 20.0, null, "2", "Handball" },
                    { 3, 1, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9141), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "High-quality goalkeeper gloves designed for handball.", "https://www.ushandball.org/wp-content/uploads/2020/04/55_202_edge-red-500x500-1.png", false, false, 40.0, 32.990000000000002, null, "M", "Handball Goalkeeper Gloves" },
                    { 4, 4, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9143), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Set of 10 training cones for handball drills and agility exercises.", "https://th.bing.com/th/id/OIP.fmooRuaDr8s4PgXttfwTrwHaHa?w=196&h=196&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 15.0, 12.5, null, null, "Handball Training Cones" },
                    { 5, 2, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Official handball jersey for players and fans.", "https://th.bing.com/th/id/OIP.-o6S2LWJvZpQfGlN06hm2gHaHa?w=182&h=182&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 30.0, 25.989999999999998, null, "XL", "Handball Jersey" },
                    { 6, 1, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sturdy handball goal for indoor and outdoor use.", "https://th.bing.com/th/id/OIP.MPaYi-lsGE9Ls6TI6vJK7QHaHa?w=198&h=198&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 120.0, 99.989999999999995, null, "Standard", "Handball Goal" },
                    { 7, 3, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Specialized court shoes with excellent grip for handball.", "https://th.bing.com/th/id/OIP.F_JVGxVV3o9j4G4xMMIl2AHaHa?w=184&h=184&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 90.0, 74.989999999999995, null, "US 11", "Handball Court Shoes" },
                    { 8, 4, "Black", new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9152), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Absorbent wristband for handball players to wipe away sweat.", "https://th.bing.com/th/id/OIP.Hj1oxc9FtHsW9fMmVKtjsgHaFT?w=250&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 8.0, 6.5, null, null, "Handball Wristband" },
                    { 9, 3, null, new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9156), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cushioned socks for maximum comfort during handball matches.", "https://th.bing.com/th/id/OIP.UJClor0v7As5z6cIXXyk9QHaHa?w=200&h=200&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 12.0, 9.9900000000000002, null, "UK 8-10", "Handball Court Socks" },
                    { 10, 2, "Yellow", new DateTime(2023, 8, 15, 23, 31, 59, 700, DateTimeKind.Local).AddTicks(9158), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sweat-absorbent headband to keep hair and sweat away during handball games.", "https://th.bing.com/th/id/OIP.gnTH3x7XoeTS3TWwKZzZKAHaHa?w=202&h=202&c=7&r=0&o=5&dpr=1.3&pid=1.7", false, false, 10.0, 7.9900000000000002, null, null, "Handball Headband" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
