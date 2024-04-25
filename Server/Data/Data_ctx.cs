using Microsoft.EntityFrameworkCore;
using Handball_Shopv1.Shared;
using static Azure.Core.HttpHeader;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Security.AccessControl;
using System;
using Microsoft.Identity.Client;
using System.Collections;

namespace Handball_Shopv1.Server.Data
{
    public class Data_ctx : DbContext
    {
        public Data_ctx(DbContextOptions<Data_ctx> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Variants> Platforms { get; set; }
        public DbSet<Statistics> Statistics { get; set; }

        public List<double> originalprices { get; set; } = new List<double> { 6.99, 20, 17, 9.99, 27, 349.99, 69.99, 3.99, 2, 3 };
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Variants_Product>().HasKey(p => new { p.ProductId, p.AdditionId });


            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Equipment", Url = "equipment", Icon = "basketball" },
                    new Category { Id = 2, Name = "Sportswear", Url = "clothes", Icon = "tshirt" },
                    new Category { Id = 3, Name = "Footwear", Url = "Footwear", Icon = "shoe-prints" },
                    new Category { Id = 4, Name = "Accessories", Url = "accessories", Icon = "headphones" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 4,
                    Title = "Resin",
                    Description = "A sticky substance applied to the hands or ball to help provide grip when catching a ball",
                    Image = "https://contents.mediadecathlon.com/p974581/k$5043e312a6d703b0fbbeee605bb2c18e/handball-200-ml-resin-white.jpg?&f=800x800",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Handball",
                    Description = "A ball used in the sport of handball, the ball comes in different sizes ranging from 1 to 3 where 1 is for individuals aged below 9, where 2 is for 9-16, and 3 is for ages 16+",
                    Image = "https://th.bing.com/th/id/OIP.MWZvNTIlLKSKX-GA1fxD1wHaJ2?w=149&h=195&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    SizeOfPreview = "2",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Handball Goalkeeper Gloves",
                    Description = "High-quality goalkeeper gloves designed for handball.",
                    Image = "https://www.ushandball.org/wp-content/uploads/2020/04/55_202_edge-red-500x500-1.png",
                    SizeOfPreview = "M",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 4,
                    Title = "Handball Training Cones",
                    Description = "Set of 10 training cones for handball drills and agility exercises.",
                    Image = "https://th.bing.com/th/id/OIP.fmooRuaDr8s4PgXttfwTrwHaHa?w=196&h=196&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Handball Jersey",
                    Description = "Official handball jersey for players and fans.",
                    Image = "https://th.bing.com/th/id/OIP.-o6S2LWJvZpQfGlN06hm2gHaHa?w=182&h=182&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    SizeOfPreview = "XL",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 1,
                    Title = "Handball Goal",
                    Description = "Sturdy handball goal for indoor and outdoor use.",
                    Image = "https://th.bing.com/th/id/OIP.MPaYi-lsGE9Ls6TI6vJK7QHaHa?w=198&h=198&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    SizeOfPreview = "Standard",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Handball Court Shoes",
                    Description = "Specialized court shoes with excellent grip for handball.",
                    Image = "https://th.bing.com/th/id/OIP.F_JVGxVV3o9j4G4xMMIl2AHaHa?w=184&h=184&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    SizeOfPreview = "US 11",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 4,
                    Title = "Handball Wristband",
                    Description = "Absorbent wristband for handball players to wipe away sweat.",
                    Image = "https://th.bing.com/th/id/OIP.Hj1oxc9FtHsW9fMmVKtjsgHaFT?w=250&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    ColorOfPreview = "Black",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "Handball Court Socks",
                    Description = "Cushioned socks for maximum comfort during handball matches.",
                    Image = "https://th.bing.com/th/id/OIP.UJClor0v7As5z6cIXXyk9QHaHa?w=200&h=200&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    SizeOfPreview = "UK 8-10",
                    DateCreated = new DateTime(2023, 08, 10)
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 2,
                    Title = "Handball Headband",
                    Description = "Sweat-absorbent headband to keep hair and sweat away during handball games.",
                    Image = "https://th.bing.com/th/id/OIP.gnTH3x7XoeTS3TWwKZzZKAHaHa?w=202&h=202&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    ColorOfPreview = "Black",
                    DateCreated = new DateTime(2023, 08, 10)
                }
            );


            modelBuilder.Entity<Variants>().HasData(
                new Variants { Id = 1, Name = "XS" },
                new Variants { Id = 2, Name = "S" },
                new Variants { Id = 3, Name = "M" },
                new Variants { Id = 4, Name = "L" },
                new Variants { Id = 5, Name = "XL" },
                new Variants { Id = 6, Name = "1" },
                new Variants { Id = 7, Name = "2" },
                new Variants { Id = 8, Name = "3" },
                new Variants { Id = 9, Name = "Default" }
            );//2, 3, 5, 7, 9, 10

            modelBuilder.Entity<Variants_Product>().HasData(

                new Variants_Product //Product Title: Resin == Product ID: 1
                {
                    AdditionId = 9,
                    ProductId = 1,
                    OriginalPrice = originalprices[0],
                    Price = originalprices[0],
                },
                new Variants_Product //Product Title: Handball Ball == Product ID:2
                {
                    AdditionId = 6,
                    ProductId = 2,
                    OriginalPrice = originalprices[1],
                    Price = originalprices[1],

                },
                new Variants_Product
                {
                    AdditionId = 7,
                    ProductId = 2,
                    Price = originalprices[1] + (0.2 * originalprices[1]),
                },
                new Variants_Product
                {
                    AdditionId = 8,
                    ProductId = 2,
                    Price = originalprices[1] + (0.2 * originalprices[1]),
                },
                new Variants_Product
                {
                    AdditionId = 1,
                    ProductId = 3,
                    OriginalPrice = originalprices[2],
                    Price = originalprices[2],

                },
                new Variants_Product
                {
                    AdditionId = 2,
                    ProductId = 3,
                    Price = originalprices[2] + (0.2 * originalprices[2]),
                },
                new Variants_Product
                {
                    AdditionId = 3,
                    ProductId = 3,
                    Price = originalprices[2] + (0.2 * originalprices[2]),
                },
                new Variants_Product
                {
                    AdditionId = 4,
                    ProductId = 3,
                    Price = originalprices[2] + (0.2 * originalprices[2]),
                },
                new Variants_Product
                {
                    AdditionId = 5,
                    ProductId = 3,
                    Price = originalprices[2] + (0.2 * originalprices[2]),
                },
                new Variants_Product
                {
                    AdditionId = 9,
                    ProductId = 4,
                    OriginalPrice = originalprices[3],
                    Price = originalprices[3],

                },
                new Variants_Product
                {
                    AdditionId = 1,
                    ProductId = 5,
                    OriginalPrice = originalprices[4],
                    Price = originalprices[4],

                },
                new Variants_Product
                {
                    AdditionId = 2,
                    ProductId = 5,
                    Price = originalprices[4] + (0.2 * originalprices[4]),
                },
                new Variants_Product
                {
                    AdditionId = 3,
                    ProductId = 5,
                    Price = originalprices[4] + (0.2 * originalprices[4]),
                },
                new Variants_Product
                {
                    AdditionId = 4,
                    ProductId = 5,
                    Price = originalprices[4] + (0.2 * originalprices[4]),
                },
                new Variants_Product
                {
                    AdditionId = 5,
                    ProductId = 5,
                    Price = originalprices[4] + (0.2 * originalprices[4]),
                },
                new Variants_Product
                {
                    AdditionId = 9,
                    ProductId = 6,
                    OriginalPrice = originalprices[5],
                    Price = originalprices[5],

                },
                new Variants_Product
                {
                    AdditionId = 1,
                    ProductId = 7,
                    OriginalPrice = originalprices[6],
                    Price = originalprices[6],

                },
                new Variants_Product
                {
                    AdditionId = 2,
                    ProductId = 7,
                    Price = originalprices[6] + (0.2 * originalprices[6]),
                },
                new Variants_Product
                {
                    AdditionId = 3,
                    ProductId = 7,
                    Price = originalprices[6] + (0.2 * originalprices[6]),
                },
                new Variants_Product
                {
                    AdditionId = 4,
                    ProductId = 7,
                    Price = originalprices[6] + (0.2 * originalprices[6]),
                },
                new Variants_Product
                {
                    AdditionId = 5,
                    ProductId = 7,
                    Price = originalprices[6] + (0.2 * originalprices[6]),
                },
                new Variants_Product
                {
                    AdditionId = 9,
                    ProductId = 8,
                    OriginalPrice = originalprices[7],
                    Price = originalprices[7],

                },
                new Variants_Product
                {
                    AdditionId = 1,
                    ProductId = 9,
                    OriginalPrice = originalprices[8],
                    Price = originalprices[8],

                },
                new Variants_Product
                {
                    AdditionId = 2,
                    ProductId = 9,
                    Price = originalprices[8] + (0.2 * originalprices[8]),
                },
                new Variants_Product
                {
                    AdditionId = 3,
                    ProductId = 9,
                    Price = originalprices[8] + (0.2 * originalprices[8]),
                },
                new Variants_Product
                {
                    AdditionId = 4,
                    ProductId = 9,
                    Price = originalprices[8] + (0.2 * originalprices[8]),
                },
                new Variants_Product
                {
                    AdditionId = 5,
                    ProductId = 9,
                    Price = originalprices[8] + (0.2 * originalprices[8]),
                },
                new Variants_Product
                {
                    AdditionId = 1,
                    ProductId = 10,
                    OriginalPrice = originalprices[9],
                    Price = originalprices[9],

                },
                new Variants_Product
                {
                    AdditionId = 2,
                    ProductId = 10,
                    Price = originalprices[9] + (0.2 * originalprices[9]),
                },
                new Variants_Product
                {
                    AdditionId = 3,
                    ProductId = 10,
                    Price = originalprices[9] + (0.2 * originalprices[9]),
                },
                new Variants_Product
                {
                    AdditionId = 4,
                    ProductId = 10,
                    Price = originalprices[9] + (0.2 * originalprices[9]),
                },
                new Variants_Product
                {
                    AdditionId = 5,
                    ProductId = 10,
                    Price = originalprices[9] + (0.2 * originalprices[9]),
                }
            );
        }
    }
}