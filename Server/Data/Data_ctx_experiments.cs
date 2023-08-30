
//List<object> platfromproductdata_size = new List<object>();

//List<int> Listofproducts_size = new List<int> { 3, 5, 7, 9 };
//foreach (var product_id in Listofproducts_size)
//{
//    for (int platform_Id = 12; platform_Id <= 16; platform_Id++)
//    {
//        platfromproductdata_size.Add(new { Platfroms_sizeId = platform_Id, ProductsId = product_id });
//    }
//}

//modelBuilder.Entity<Platform>().HasData(
//                new Platform { Id = 1, Name = "Yellow" },
//                new Platform { Id = 2, Name = "Red" },
//                new Platform { Id = 3, Name = "Blue" },
//                new Platform { Id = 4, Name = "Green" },
//                new Platform { Id = 5, Name = "Orange" },
//                new Platform { Id = 6, Name = "Purple" },
//                new Platform { Id = 7, Name = "Pink" },
//                new Platform { Id = 8, Name = "Brown" },
//                new Platform { Id = 9, Name = "White" },
//                new Platform { Id = 10, Name = "Black" },
//                new Platform { Id = 11, Name = "Gray" }
//            );//products with size 2,3,5,7,9 & products with color 8,10
//List<object> platformproductdata_color = new List<object>();

//List<int> Listofproducts_color = new List<int> { 8, 10 };

//foreach (var productId in Listofproducts_color)
//{
//    for (int platformId = 1; platformId <= 11; platformId++)
//    {
//        platformproductdata_color.Add(new { PlatformsId = platformId, ProductsId = productId });
//    }
//}
//modelBuilder.SharedTypeEntity<Dictionary<string, object>>("PlatformProduct").HasData(
//    platformproductdata_color
//);






//modelBuilder.Entity<Platfrom_size>().HasData(
//    new Platfrom_size { Id = 12, Name = "XS" },
//    new Platfrom_size { Id = 13, Name = "S" },
//    new Platfrom_size { Id = 14, Name = "M" },
//    new Platfrom_size { Id = 15, Name = "L" },
//    new Platfrom_size { Id = 16, Name = "XL" },
//    new Platfrom_size { Id = 17, Name = "1" },
//    new Platfrom_size { Id = 18, Name = "2" },
//    new Platfrom_size { Id = 19, Name = "3" }
//);
//modelBuilder.SharedTypeEntity<Dictionary<string, object>>("Platfroms_sizeId").HasData(
//    new { Platfroms_sizeId = 12, ProductsId = 3 },
//    new { Platfroms_sizeId = 13, ProductsId = 3 },
//    new { Platforms_sizeId = 14, ProductsId = 3 },
//    new { Platfroms_sizeId = 15, ProductsId = 3 },
//    new { Platfroms_sizeId = 16, ProductsId = 3 },
//    new { Platfroms_sizeId = 17, ProductsId = 2 },
//    new { Platfroms_sizeId = 18, ProductsId = 2 },
//    new { Platfroms_sizeId = 19, ProductsId = 2 },
//    new { Platfroms_sizeId = 12, ProductsId = 5 },
//    new { Platfroms_sizeId = 13, ProductsId = 5 },
//    new { Platfroms_sizeId = 14, ProductsId = 5 },
//    new { Platfroms_sizeId = 15, ProductsId = 5 },
//    new { Platfroms_sizeId = 16, ProductsId = 5 },
//    new { Platfroms_sizeId = 12, ProductsId = 7 },
//    new { Platfroms_sizeId = 13, ProductsId = 7 },
//    new { Platfroms_sizeId = 14, ProductsId = 7 },
//    new { Platfroms_sizeId = 15, ProductsId = 7 },
//    new { Platfroms_sizeId = 16, ProductsId = 7 },
//    new { Platfroms_sizeId = 12, ProductsId = 9 },
//    new { Platfroms_sizeId = 13, ProductsId = 9 },
//    new { Platfroms_sizeId = 14, ProductsId = 9 },
//    new { Platfroms_sizeId = 15, ProductsId = 9 },
//    new { Platfroms_sizeId = 16, ProductsId = 9 }
//);





//List<object> platformproductdata_size = new List<object>();

//List<int> ListProductsUsingSize = new List<int> { 3, 5, 7, 9, 10 };

//for (int i = 6; i <= 8; i++)
//{
//    platformproductdata_size.Add(new { PlatformsId = i, ProductsId = 2 });

//}
//foreach (var productId in ListProductsUsingSize)
//{
//    for (int platformId = 1; platformId <= 5; platformId++)
//    {
//        platformproductdata_size.Add(new { PlatformsId = platformId, ProductsId = productId });
//    }
//}

//modelBuilder.SharedTypeEntity<Dictionary<string, object>>("PlatformProduct").HasData(
//    platformproductdata_size
//);