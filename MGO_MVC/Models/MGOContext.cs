using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MGO_MVC.Models
{
    public class MGOContext : DbContext
    {
        public MGOContext(DbContextOptions<MGOContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }


        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<PurchaseItem> PurchaseItems { get; set; }

        public DbSet<SaleItem> SaleItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 283, Name = "Backpacks" },
                new Category { CategoryId = 320, Name = "Mountain Bikes" },
                new Category { CategoryId = 410, Name = "Sleeping Bags" },
                new Category { CategoryId = 477, Name = "Tents" },
                new Category { CategoryId = 685, Name = "Downhill Ski Boots" },
                new Category { CategoryId = 729, Name = "Downhill Skis" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 11, FirstName = "Todd", LastName = "Lockard", Street1 = "5634 Furnace Hill Rd.", City = "Murfreesboro", State = "TN", ZIP = "37130", Email = "tlock1212@hotmail.com" },
                new Customer { CustomerId = 13, FirstName = "Renee", LastName = "Devlin", Street1 = "739 Birch Ave.", City = "Gatlinburg", State = "TN", ZIP = "37138", Email = "drenee12@yahoo.com" },
                new Customer { CustomerId = 15, FirstName = "Justin", LastName = "Knighton", Street1 = "513 Forest Ave.", City = "Murfreesboro", State = "TN", ZIP = "37128", Email = "naturelover@rockbridge.net" },
                new Customer { CustomerId = 20, FirstName = "Rockbridge", LastName = "Outdoors", Street1 = "8913 Stagecoach Rd.", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "rockbridgeoutdoors@mail.net" },
                new Customer { CustomerId = 23, FirstName = "Craig", LastName = "Sherry", Street1 = "909 Cedar Ave.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "sherryfamily@mail.com" },
                new Customer { CustomerId = 25, FirstName = "Jeff", LastName = "Reichert", Street1 = "4398 Old Allegheny Cir.", Street2 = "Apt. 8", City = "Gatlinburg", State = "TN", ZIP = "37138", Email = "canoemaster@hotmail.com" },
                new Customer { CustomerId = 27, FirstName = "Kathryn", LastName = "Ware", Street1 = "324 Fuller St.", City = "Murfreesboro", State = "TN", ZIP = "37128", Email = "kathyware22@yahoo.com" },
                new Customer { CustomerId = 30, FirstName = "Norman", LastName = "Hernandes", Street1 = "12 Sycamore Ave. 6", City = "Gatlinburg", State = "TN", ZIP = "37728", Email = "storminnorman@hotmail.com" },
                new Customer { CustomerId = 32, FirstName = "Stanley", LastName = "Calhoun", Street1 = "590 Gibbs St.", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "masterhiker@hotmail.com" },
                new Customer { CustomerId = 34, FirstName = "Alicia", LastName = "Moorehead", Street1 = "643 Summit St.", City = "Cherokee", State = "NC", ZIP = "37738", Email = "aliciamoorehead121@aol.com" },
                new Customer { CustomerId = 36, FirstName = "Elizabeth", LastName = "Hazelwood", Street1 = "897 Cypress Ave.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "lizhazelwood@aol.com" },
                new Customer { CustomerId = 40, FirstName = "Bridget", LastName = "Crozier", Street1 = "601 Walker St.", City = "Asheville", State = "NC", ZIP = "28715", Email = "bridgetc@rockbridge.net" },
                new Customer { CustomerId = 41, FirstName = "Grassroots", LastName = "Recreation", Street1 = "16 Rockfish School Ln.", City = "Cherokee", State = "NC", ZIP = "28719", Email = "mgmt@grassrootsrec.com" },
                new Customer { CustomerId = 42, FirstName = "Matthew", LastName = "Metz", Street1 = "2385 Mill St.", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "mattmetz@gmail.com" },
                new Customer { CustomerId = 50, FirstName = "Appalachian", LastName = "Outfitters", Street1 = "9823 Whitehill Rd.", Street2 = "Suite A", City = "Cherokee", State = "NC", ZIP = "37130", Email = "appoutfitters@gmail.com" },
                new Customer { CustomerId = 52, FirstName = "Roger", LastName = "Feliciano", Street1 = "8341 Maury River Rd.", City = "Ashville", State = "NC", ZIP = "28732", Email = "rogerfeliciano12@rockbridge.net" },
                new Customer { CustomerId = 55, FirstName = "Johnny", LastName = "Driggers", Street1 = "6783 Allegheny Dr.", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "johnnylovesnature@gmail.com" },
                new Customer { CustomerId = 57, FirstName = "Ernest", LastName = "Cochrane", Street1 = "9013 Main St.", City = "Cherokee", State = "NC", ZIP = "28719", Email = "erniec53@live.com" },
                new Customer { CustomerId = 58, FirstName = "Joshua", LastName = "Botello", Street1 = "704 Peyton St.", City = "Murfreesboro", State = "TN", ZIP = "37128", Email = "joshieb@mail.com" },
                new Customer { CustomerId = 60, FirstName = "Tiffany", LastName = "Bradford", Street1 = "745 Davidson St.", City = "Ashville", State = "NC", ZIP = "28715", Email = "tbradford3@mail.com" },
                new Customer { CustomerId = 61, FirstName = "Adam", LastName = "Vigil", Street1 = "801 Chestnut Ave.", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "vigila23@hotmail.com" },
                new Customer { CustomerId = 64, FirstName = "Blue", LastName = "Ridge Rafting", Street1 = "17003 Crabtree Falls Hwy.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "management@brafting.com" },
                new Customer { CustomerId = 66, FirstName = "Bryan", LastName = "Seals", Street1 = "17 W. McDowell St", City = "Cherokee", State = "NC", ZIP = "28719", Email = "bseals@rockbridge.net" },
                new Customer { CustomerId = 69, FirstName = "Eugene", LastName = "Nixon", Street1 = "901 Walnut Ave.", City = "Asheville", State = "NC", ZIP = "38732", Email = "mountainbiker12@hotmail.com" },
                new Customer { CustomerId = 70, FirstName = "Sheryl", LastName = "Vaught", Street1 = "316 Short St.", Street2 = "Apt. 14", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "hikeallday@rockbridge.net" },
                new Customer { CustomerId = 71, FirstName = "Tyler", LastName = "Dominick", Street1 = "5490 Stillwater Dr.", City = "Asheville", State = "NC", ZIP = "28732", Email = "campingenthusiast@yahoo.com" },
                new Customer { CustomerId = 74, FirstName = "Kevin", LastName = "Banner", Street1 = "400 W. Washington St.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "skifanatic@aol.com" },
                new Customer { CustomerId = 75, FirstName = "Matthew", LastName = "Luis", Street1 = "7523 Palace Hill Ln.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "luismatt20@gmail.com" },
                new Customer { CustomerId = 78, FirstName = "Victoria", LastName = "Richey", Street1 = "762 Maple Ave.", City = "Asheville", State = "NC", ZIP = "28715", Email = "richeyfamily@yahoo.com" },
                new Customer { CustomerId = 79, FirstName = "Ramona", LastName = "Torres", Street1 = "9543 Paxton Dr.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "rtorres@mail.net" },
                new Customer { CustomerId = 82, FirstName = "Jackson", LastName = "Beaudoin", Street1 = "781 Houston St.", City = "Asheville", State = "NC", ZIP = "28732", Email = "kingkayaker@rockbridge.net" },
                new Customer { CustomerId = 86, FirstName = "Lawrence", LastName = "Heins", Street1 = "6134 Slag Ln.", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "heinslawrence@rockbridge.net" },
                new Customer { CustomerId = 88, FirstName = "Thomas", LastName = "Venable", Street1 = "513 Morningside Dr.", City = "Asheville", State = "NC", ZIP = "28715", Email = "tommyvlexington@mail.com" },
                new Customer { CustomerId = 89, FirstName = "Victor", LastName = "Bivins", Street1 = "986 Central Rd.", Street2 = "Apt. 211", City = "Knoxville", State = "TN", ZIP = "37918", Email = "bivinsv88@gmail.com" },
                new Customer { CustomerId = 92, FirstName = "Bobby", LastName = "Leftwich", Street1 = "1876 McClaughlin St.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "leftwichbob19@gmail.com" },
                new Customer { CustomerId = 95, FirstName = "Antonio", LastName = "Muse", Street1 = "2136 Rockbridge Way", City = "Gatlinburg", State = "TN", ZIP = "37738", Email = "musefamily@hotmail.com" },
                new Customer { CustomerId = 97, FirstName = "Nicholas", LastName = "Bottoms", Street1 = "7809 Red Hill Rd.", City = "Knoxville", State = "TN", ZIP = "37918", Email = "bottomsnick12@gmail.com" },
                new Customer { CustomerId = 98, FirstName = "David", LastName = "Mendes", Street1 = "891 Reagan St.", City = "Murfreesboro", State = "TN", ZIP = "37128", Email = "mendesd@gmail.com" }
           );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1063, FirstName = "Josh", LastName = "Williams", Position = "Manager", Commission = .05M },
                new Employee { EmployeeId = 1492, FirstName = "Nathan", LastName = "Bussell", Position = "Buyer/Seller", Commission = .08M },
                new Employee { EmployeeId = 3325, FirstName = "Brandy", LastName = "Chaffi", Position = "Buyer/Seller", Commission = .065M },
                new Employee { EmployeeId = 5701, FirstName = "Lori", LastName = "Kish", Position = "Seller", Commission = .08M },
                new Employee { EmployeeId = 6795, FirstName = "Tony", LastName = "Gregg", Position = "Seller", Commission = .07M }
            );

            modelBuilder.Entity<Purchase>().HasData(
                         new Purchase { PurchaseId = 2025, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2026, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2027, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2028, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2029, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2030, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2031, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2032, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2033, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2034, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2035, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2036, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2037, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2038, PurchaseDate = DateTime.Parse("2020-09-23 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2039, PurchaseDate = DateTime.Parse("2020-10-13 00:00:00.000"), EmployeeId = 3325 },
                         new Purchase { PurchaseId = 2040, PurchaseDate = DateTime.Parse("2020-10-16 00:00:00.000"), EmployeeId = 1492 },
                         new Purchase { PurchaseId = 2041, PurchaseDate = DateTime.Parse("2020-10-16 00:00:00.000"), EmployeeId = 1492 },
                         new Purchase { PurchaseId = 2042, PurchaseDate = DateTime.Parse("2020-10-16 00:00:00.000"), EmployeeId = 1492 },
                         new Purchase { PurchaseId = 2043, PurchaseDate = DateTime.Parse("2020-10-16 00:00:00.000"), EmployeeId = 1492 },
                         new Purchase { PurchaseId = 2044, PurchaseDate = DateTime.Parse("2020-10-16 00:00:00.000"), EmployeeId = 1492 }
                     );

            modelBuilder.Entity<Sale>().HasData(
                         new Sale { SaleId = 1051, SaleDate = DateTime.Parse("2020-10-04 08:30:00PM"), SaleTime = DateTime.Parse("1899-12-30 08:30:00PM"), EmployeeId = 3325, CustomerId = 61 },
                         new Sale { SaleId = 1052, SaleDate = DateTime.Parse("2020-10-05 11:45:00AM"), SaleTime = DateTime.Parse("1899-12-30 11:45AM"), EmployeeId = 1492, CustomerId = 64 },
                         new Sale { SaleId = 1053, SaleDate = DateTime.Parse("2020-10-05 6:00:00PM"), SaleTime = DateTime.Parse("1899-12-30 6:00:00PM"), EmployeeId = 1492, CustomerId = 58 },
                         new Sale { SaleId = 1054, SaleDate = DateTime.Parse("2020-10-06 12:30:00PM"), SaleTime = DateTime.Parse("1899-12-30 12:30:00PM"), EmployeeId = 6795, CustomerId = 23 },
                         new Sale { SaleId = 1055, SaleDate = DateTime.Parse("2020-10-06 12:47:00PM"), SaleTime = DateTime.Parse("1899-12-30 12:47:00PM"), EmployeeId = 6795, CustomerId = 61 },
                         new Sale { SaleId = 1056, SaleDate = DateTime.Parse("2020-10-06 1:20:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:20:00PM"), EmployeeId = 3325, CustomerId = 78 },
                         new Sale { SaleId = 1057, SaleDate = DateTime.Parse("2020-10-07 1:15:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:15:00PM"), EmployeeId = 6795, CustomerId = 30 },
                         new Sale { SaleId = 1058, SaleDate = DateTime.Parse("2020-10-07 1:45:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:45:00PM"), EmployeeId = 6795, CustomerId = 69 },
                         new Sale { SaleId = 1059, SaleDate = DateTime.Parse("2020-10-07 2:10:00PM"), SaleTime = DateTime.Parse("1899-12-30 2:10:00PM"), EmployeeId = 6795, CustomerId = 69 },
                         new Sale { SaleId = 1060, SaleDate = DateTime.Parse("2020-10-07 5:38:00PM"), SaleTime = DateTime.Parse("1899-12-30 5:38:00PM"), EmployeeId = 6795, CustomerId = 66 },
                         new Sale { SaleId = 1061, SaleDate = DateTime.Parse("2020-10-08 2:00:00PM"), SaleTime = DateTime.Parse("1899-12-30 2:00:00PM"), EmployeeId = 1492, CustomerId = 40 },
                         new Sale { SaleId = 1062, SaleDate = DateTime.Parse("2020-10-08 5:40:00PM"), SaleTime = DateTime.Parse("1899-12-30 5:40:00PM"), EmployeeId = 6795, CustomerId = 92 },
                         new Sale { SaleId = 1063, SaleDate = DateTime.Parse("2020-10-11 2:00:00PM"), SaleTime = DateTime.Parse("1899-12-30 2:00:00PM"), EmployeeId = 3325, CustomerId = 70 },
                         new Sale { SaleId = 1064, SaleDate = DateTime.Parse("2020-10-11 5:45:00PM"), SaleTime = DateTime.Parse("1899-12-30 5:45:00PM"), EmployeeId = 1492, CustomerId = 88 },
                         new Sale { SaleId = 1065, SaleDate = DateTime.Parse("2020-10-11 8:37:00PM"), SaleTime = DateTime.Parse("1899-12-30 8:37:00PM"), EmployeeId = 3325, CustomerId = 25 },
                         new Sale { SaleId = 1066, SaleDate = DateTime.Parse("2020-10-12 1:15:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:15:00PM"), EmployeeId = 1492, CustomerId = 60 },
                         new Sale { SaleId = 1067, SaleDate = DateTime.Parse("2020-10-13 2:15:00PM"), SaleTime = DateTime.Parse("1899-12-30 2:15:00PM"), EmployeeId = 1492, CustomerId = 89 },
                         new Sale { SaleId = 1068, SaleDate = DateTime.Parse("2020-10-13 7:00:00PM"), SaleTime = DateTime.Parse("1899-12-30 7:00:00PM"), EmployeeId = 3325, CustomerId = 79 },
                         new Sale { SaleId = 1069, SaleDate = DateTime.Parse("2020-10-13 7:15:00PM"), SaleTime = DateTime.Parse("1899-12-30 7:15:00PM"), EmployeeId = 1492, CustomerId = 34 },
                         new Sale { SaleId = 1070, SaleDate = DateTime.Parse("2020-10-13 8:00:00PM"), SaleTime = DateTime.Parse("1899-12-30 8:00:00PM"), EmployeeId = 1492, CustomerId = 15 },
                         new Sale { SaleId = 1071, SaleDate = DateTime.Parse("2020-10-15 5:30:00PM"), SaleTime = DateTime.Parse("1899-12-30 5:30:00PM"), EmployeeId = 5701, CustomerId = 74 },
                         new Sale { SaleId = 1072, SaleDate = DateTime.Parse("2020-10-15 6:45:00PM"), SaleTime = DateTime.Parse("1899-12-30 6:45:00PM"), EmployeeId = 5701, CustomerId = 97 },
                         new Sale { SaleId = 1073, SaleDate = DateTime.Parse("2020-10-16 12:45:00PM"), SaleTime = DateTime.Parse("1899-12-30 12:45:00PM"), EmployeeId = 1492, CustomerId = 36 },
                         new Sale { SaleId = 1074, SaleDate = DateTime.Parse("2020-10-16 1:30:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:30:00PM"), EmployeeId = 1492, CustomerId = 32 },
                         new Sale { SaleId = 1075, SaleDate = DateTime.Parse("2020-10-16 03:15:00PM"), SaleTime = DateTime.Parse("1899-12-30 03:15:00PM"), EmployeeId = 5701, CustomerId = 98 },
                         new Sale { SaleId = 1076, SaleDate = DateTime.Parse("2020-10-16 6:45:00PM"), SaleTime = DateTime.Parse("1899-12-30 6:45:00PM"), EmployeeId = 1492, CustomerId = 13 },
                         new Sale { SaleId = 1077, SaleDate = DateTime.Parse("2020-10-16 08:30:00PM"), SaleTime = DateTime.Parse("1899-12-30 08:30:00PM"), EmployeeId = 1492, CustomerId = 27 },
                         new Sale { SaleId = 1078, SaleDate = DateTime.Parse("2020-10-17 1:10:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:10:00PM"), EmployeeId = 3325, CustomerId = 23 },
                         new Sale { SaleId = 1079, SaleDate = DateTime.Parse("2020-10-17 1:15:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:15:00PM"), EmployeeId = 5701, CustomerId = 82 },
                         new Sale { SaleId = 1080, SaleDate = DateTime.Parse("2020-10-18 1:45:00PM"), SaleTime = DateTime.Parse("1899-12-30 1:45:00PM"), EmployeeId = 3325, CustomerId = 11 },
                         new Sale { SaleId = 1081, SaleDate = DateTime.Parse("2020-10-18 7:38:00PM"), SaleTime = DateTime.Parse("1899-12-30 7:38:00PM"), EmployeeId = 3325, CustomerId = 75 },
                         new Sale { SaleId = 1082, SaleDate = DateTime.Parse("2020-10-18 7:45:00PM"), SaleTime = DateTime.Parse("1899-12-30  7:45:00PM"), EmployeeId = 6795, CustomerId = 92 },
                         new Sale { SaleId = 1083, SaleDate = DateTime.Parse("2020-10-18 7:50:00PM"), SaleTime = DateTime.Parse("1899-12-30 7:50:00PM"), EmployeeId = 3325, CustomerId = 86 },
                         new Sale { SaleId = 1084, SaleDate = DateTime.Parse("2020-10-18 7:55:00PM"), SaleTime = DateTime.Parse("1899-12-30 7:55:00PM"), EmployeeId = 6795, CustomerId = 70 }

                     );


            modelBuilder.Entity<Item>().HasData(
                new Item { ItemId = 1299, Name = "Sierra Designs Pyro 15", Price = 249.95M, Cost = 125.00M, CategoryId = 410},
                new Item { ItemId = 1318, Name = "Rossignol Avenger 76 Carbon", Price = 559.96M, Cost = 280.00M, CategoryId = 729 },
                new Item { ItemId = 1327, Name = "Mountain Safety Research Mutha Hubba", Price = 399.95M, Cost = 200.00M, CategoryId = 477 },
                new Item { ItemId = 1662, Name = "Lange Concept 9", Price = 399.95M, Cost = 200.00M, CategoryId = 685 },
                new Item { ItemId = 2342, Name = "GT Ruckus DJ 2.0", Price = 929.00M, Cost = 465.00M, CategoryId = 320 },
                new Item { ItemId = 2395, Name = "Sierra Designs Lightning XT4", Price = 459.95M, Cost = 230.00M, CategoryId = 477 },
                new Item { ItemId = 3161, Name = "Mountainsmtih Lookout 45", Price = 159.00M, Cost = 80.00M, CategoryId = 283 },
                new Item { ItemId = 3410, Name = "Sierra Designs Convert 2", Price = 449.95M, Cost = 225.00M, CategoryId = 477 },
                new Item { ItemId = 3486, Name = "K2 Shockwave", Price = 725.00M, Cost = 362.5M, CategoryId = 729 },
                new Item { ItemId = 4295, Name = "Cannondale Claymore 2", Price = 4599.00M, Cost = 2300.00M, CategoryId = 320 },
                new Item { ItemId = 4563, Name = "The North Face Nebula", Price = 369.00M, Cost = 185.00M, CategoryId = 410 },
                new Item { ItemId = 4706, Name = "Marmot Thor 3P", Price = 550.00M, Cost = 275.00M, CategoryId = 477 },
                new Item { ItemId = 4809, Name = "The North Face El Lobo 60", Price = 249.00M, Cost = 125.00M, CategoryId = 283 },
                new Item { ItemId = 4978, Name = "Kelty Shrike 32", Price = 89.95M, Cost = 45.00M, CategoryId = 283 },
                new Item { ItemId = 5284, Name = "Salomon Quest 8", Price = 349.99M, Cost = 175.00M, CategoryId = 685 },
                new Item { ItemId = 5909, Name = "Kelty Buttress 6", Price = 299.95M, Cost = 150.00M, CategoryId = 477 },
                new Item { ItemId = 6195, Name = "Tecnica USA Agent 80", Price = 495.00M, Cost = 247.5M, CategoryId = 685 },
                new Item { ItemId = 7571, Name = "Kelty Yukon 48", Price = 119.95M, Cost = 60.00M, CategoryId = 283 },
                new Item { ItemId = 7614, Name = "Sierra Designs Vapor 15", Price = 419.95M, Cost = 210.00M, CategoryId = 410 },
                new Item { ItemId = 7816, Name = "Trek Ticket Signature", Price = 2749.99M, Cost = 1375.00M, CategoryId = 320 },
                new Item { ItemId = 7931, Name = "Specialized Rockhopper", Price = 720.00M, Cost = 360.00M, CategoryId = 320 },
                new Item { ItemId = 8148, Name = "Rossignol Synergy Sensor 100", Price = 479.95M, Cost = 240.00M, CategoryId = 685 },
                new Item { ItemId = 9034, Name = "The North Face Dark Star", Price = 309.00M, Cost = 154.50M, CategoryId = 410 },
                new Item { ItemId = 9398, Name = "Salomon BBR 7.9", Price = 599.95M, Cost = 300.00M, CategoryId = 729 },
                new Item { ItemId = 9887, Name = "Mountainsmith Apex 75", Price = 189.00M, Cost = 94.50M, CategoryId = 283 }
                );



            //many-to-many relationship for SaleItem table

            // composite primary key
            modelBuilder.Entity<SaleItem>()
                .HasKey(s => new { s.ItemId, s.SaleId });

            // one-to-many relationship sale and saleitem
            modelBuilder.Entity<SaleItem>()
                .HasOne(s => s.Sale)
                .WithMany(s => s.SaleItems)
                .HasForeignKey(s => s.SaleId);

            // one-to-many relationship item and saleitem
            modelBuilder.Entity<SaleItem>()
                .HasOne(s => s.Item)
                .WithMany(i => i.SaleItems)
                .HasForeignKey(s => s.ItemId);
                

            modelBuilder.Entity<SaleItem>().HasData(
                new SaleItem { SaleId = 1051, SaleQtySold = 1, ItemId = 4706 },
                new SaleItem { SaleId = 1052, SaleQtySold = 5, ItemId = 3486 },
                new SaleItem { SaleId = 1052, SaleQtySold = 2, ItemId = 6195 },
                new SaleItem { SaleId = 1053, SaleQtySold = 1, ItemId = 3486 },
                new SaleItem { SaleId = 1053, SaleQtySold = 1, ItemId = 8148 },
                new SaleItem { SaleId = 1054, SaleQtySold = 1, ItemId = 2395 },
                new SaleItem { SaleId = 1054, SaleQtySold = 1, ItemId = 4563 },
                new SaleItem { SaleId = 1054, SaleQtySold = 1, ItemId = 4809 },
                new SaleItem { SaleId = 1055, SaleQtySold = 1, ItemId = 3410 },
                new SaleItem { SaleId = 1055, SaleQtySold = 1, ItemId = 7614 },
                new SaleItem { SaleId = 1056, SaleQtySold = 1, ItemId = 2342 },
                new SaleItem { SaleId = 1057, SaleQtySold = 1, ItemId = 1327 },
                new SaleItem { SaleId = 1058, SaleQtySold = 2, ItemId = 1299 },
                new SaleItem { SaleId = 1058, SaleQtySold = 1, ItemId = 7571 },
                new SaleItem { SaleId = 1059, SaleQtySold = 1, ItemId = 6195 },
                new SaleItem { SaleId = 1060, SaleQtySold = 1, ItemId = 1318 },
                new SaleItem { SaleId = 1060, SaleQtySold = 1, ItemId = 6195 },
                new SaleItem { SaleId = 1061, SaleQtySold = 1, ItemId = 2342 },
                new SaleItem { SaleId = 1062, SaleQtySold = 1, ItemId = 3161 },
                new SaleItem { SaleId = 1063, SaleQtySold = 1, ItemId = 6195 },
                new SaleItem { SaleId = 1063, SaleQtySold = 1, ItemId = 9398 },
                new SaleItem { SaleId = 1064, SaleQtySold = 3, ItemId = 4295 },
                new SaleItem { SaleId = 1065, SaleQtySold = 1, ItemId = 1662 },
                new SaleItem { SaleId = 1065, SaleQtySold = 1, ItemId = 8148 },
                new SaleItem { SaleId = 1065, SaleQtySold = 3, ItemId = 9887 },
                new SaleItem { SaleId = 1066, SaleQtySold = 1, ItemId = 7816 },
                new SaleItem { SaleId = 1067, SaleQtySold = 2, ItemId = 7816 },
                new SaleItem { SaleId = 1068, SaleQtySold = 1, ItemId = 5909 },
                new SaleItem { SaleId = 1069, SaleQtySold = 1, ItemId = 1662 },
                new SaleItem { SaleId = 1070, SaleQtySold = 1, ItemId = 2395 },
                new SaleItem { SaleId = 1070, SaleQtySold = 1, ItemId = 4563 },
                new SaleItem { SaleId = 1071, SaleQtySold = 1, ItemId = 7816 },
                new SaleItem { SaleId = 1072, SaleQtySold = 1, ItemId = 2395 },
                new SaleItem { SaleId = 1072, SaleQtySold = 1, ItemId = 4809 },
                new SaleItem { SaleId = 1073, SaleQtySold = 1, ItemId = 4809 },
                new SaleItem { SaleId = 1074, SaleQtySold = 1, ItemId = 1662 },
                new SaleItem { SaleId = 1074, SaleQtySold = 1, ItemId = 9398 },
                new SaleItem { SaleId = 1075, SaleQtySold = 1, ItemId = 3161 },
                new SaleItem { SaleId = 1076, SaleQtySold = 1, ItemId = 4706 },
                new SaleItem { SaleId = 1077, SaleQtySold = 1, ItemId = 7816 },
                new SaleItem { SaleId = 1078, SaleQtySold = 1, ItemId = 4978 },
                new SaleItem { SaleId = 1079, SaleQtySold = 1, ItemId = 5284 },
                new SaleItem { SaleId = 1080, SaleQtySold = 1, ItemId = 1318 },
                new SaleItem { SaleId = 1080, SaleQtySold = 1, ItemId = 3486 },
                new SaleItem { SaleId = 1080, SaleQtySold = 1, ItemId = 9887 },
                new SaleItem { SaleId = 1081, SaleQtySold = 2, ItemId = 9887 },
                new SaleItem { SaleId = 1082, SaleQtySold = 1, ItemId = 3161 },
                new SaleItem { SaleId = 1083, SaleQtySold = 1, ItemId = 1318 },
                new SaleItem { SaleId = 1083, SaleQtySold = 1, ItemId = 3486 },
                new SaleItem { SaleId = 1083, SaleQtySold = 1, ItemId = 5284 },
                new SaleItem { SaleId = 1083, SaleQtySold = 1, ItemId = 9034 },
                new SaleItem { SaleId = 1084, SaleQtySold = 3, ItemId = 3486 }
            );

            //many-to-many relationship for PurchaseItem table

            // composite primary key
            modelBuilder.Entity<PurchaseItem>()
                .HasKey(p => new { p.PurchaseId, p.ItemId });

            // one-to-many relationship purchase and purchaseitem
            modelBuilder.Entity<PurchaseItem>()
                .HasOne(p => p.Purchase)
                .WithMany(p => p.PurchaseItems)
                .HasForeignKey(p => p.PurchaseId);

            // one-to-many relationship item and purchaseitem
            modelBuilder.Entity<PurchaseItem>()
                .HasOne(p => p.Item)
                .WithMany(i => i.PurchaseItems)
                .HasForeignKey(p => p.ItemId);

            modelBuilder.Entity<PurchaseItem>().HasData(
                         new PurchaseItem { PurchaseId = 2025, PurchaseQty = 3, ItemId = 3161 },
                         new PurchaseItem { PurchaseId = 2025, PurchaseQty = 10, ItemId = 9887 },
                         new PurchaseItem { PurchaseId = 2025, PurchaseQty = 2, ItemId = 1299 },
                         new PurchaseItem { PurchaseId = 2026, PurchaseQty = 4, ItemId = 2395 },
                         new PurchaseItem { PurchaseId = 2026, PurchaseQty = 3, ItemId = 3410 },
                         new PurchaseItem { PurchaseId = 2026, PurchaseQty = 3, ItemId = 7614 },
                         new PurchaseItem { PurchaseId = 2027, PurchaseQty = 3, ItemId = 4978 },
                         new PurchaseItem { PurchaseId = 2027, PurchaseQty = 3, ItemId = 5909 },
                         new PurchaseItem { PurchaseId = 2027, PurchaseQty = 3, ItemId = 7571 },
                         new PurchaseItem { PurchaseId = 2028, PurchaseQty = 5, ItemId = 6195 },
                         new PurchaseItem { PurchaseId = 2029, PurchaseQty = 5, ItemId = 1662 },
                         new PurchaseItem { PurchaseId = 2030, PurchaseQty = 3, ItemId = 1327 },
                         new PurchaseItem { PurchaseId = 2031, PurchaseQty = 3, ItemId = 4563 },
                         new PurchaseItem { PurchaseId = 2031, PurchaseQty = 3, ItemId = 4809 },
                         new PurchaseItem { PurchaseId = 2031, PurchaseQty = 3, ItemId = 9034 },
                         new PurchaseItem { PurchaseId = 2032, PurchaseQty = 4, ItemId = 4706 },
                         new PurchaseItem { PurchaseId = 2033, PurchaseQty = 2, ItemId = 1318 },
                         new PurchaseItem { PurchaseId = 2033, PurchaseQty = 4, ItemId = 8148 },
                         new PurchaseItem { PurchaseId = 2034, PurchaseQty = 6, ItemId = 3486 },
                         new PurchaseItem { PurchaseId = 2035, PurchaseQty = 2, ItemId = 5284 },
                         new PurchaseItem { PurchaseId = 2035, PurchaseQty = 2, ItemId = 9398 },
                         new PurchaseItem { PurchaseId = 2036, PurchaseQty = 3, ItemId = 4295 },
                         new PurchaseItem { PurchaseId = 2037, PurchaseQty = 3, ItemId = 2342 },
                         new PurchaseItem { PurchaseId = 2038, PurchaseQty = 4, ItemId = 7816 },
                         new PurchaseItem { PurchaseId = 2039, PurchaseQty = 6, ItemId = 7816 },
                         new PurchaseItem { PurchaseId = 2040, PurchaseQty = 3, ItemId = 2395 },
                         new PurchaseItem { PurchaseId = 2041, PurchaseQty = 3, ItemId = 6195 },
                         new PurchaseItem { PurchaseId = 2042, PurchaseQty = 3, ItemId = 4563 },
                         new PurchaseItem { PurchaseId = 2043, PurchaseQty = 10, ItemId = 3486 },
                         new PurchaseItem { PurchaseId = 2044, PurchaseQty = 3, ItemId = 3161 }
                     );

        }
    }
}
