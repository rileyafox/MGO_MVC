using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MGO_MVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commission = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_Purchases_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaleTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseItems",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    PurchaseQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItems", x => new { x.PurchaseId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_PurchaseItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_Purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchases",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    SaleQtySold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItems", x => new { x.ItemId, x.SaleId });
                    table.ForeignKey(
                        name: "FK_SaleItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItems_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 283, "Backpacks" },
                    { 320, "Mountain Bikes" },
                    { 410, "Sleeping Bags" },
                    { 477, "Tents" },
                    { 685, "Downhill Ski Boots" },
                    { 729, "Downhill Skis" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Email", "FirstName", "LastName", "State", "Street1", "Street2", "ZIP" },
                values: new object[,]
                {
                    { 64, "Knoxville", "management@brafting.com", "Blue", "Ridge Rafting", "TN", "17003 Crabtree Falls Hwy.", null, "37918" },
                    { 66, "Cherokee", "bseals@rockbridge.net", "Bryan", "Seals", "NC", "17 W. McDowell St", null, "28719" },
                    { 69, "Asheville", "mountainbiker12@hotmail.com", "Eugene", "Nixon", "NC", "901 Walnut Ave.", null, "38732" },
                    { 70, "Gatlinburg", "hikeallday@rockbridge.net", "Sheryl", "Vaught", "TN", "316 Short St.", "Apt. 14", "37738" },
                    { 71, "Asheville", "campingenthusiast@yahoo.com", "Tyler", "Dominick", "NC", "5490 Stillwater Dr.", null, "28732" },
                    { 74, "Knoxville", "skifanatic@aol.com", "Kevin", "Banner", "TN", "400 W. Washington St.", null, "37918" },
                    { 75, "Knoxville", "luismatt20@gmail.com", "Matthew", "Luis", "TN", "7523 Palace Hill Ln.", null, "37918" },
                    { 78, "Asheville", "richeyfamily@yahoo.com", "Victoria", "Richey", "NC", "762 Maple Ave.", null, "28715" },
                    { 86, "Gatlinburg", "heinslawrence@rockbridge.net", "Lawrence", "Heins", "TN", "6134 Slag Ln.", null, "37738" },
                    { 82, "Asheville", "kingkayaker@rockbridge.net", "Jackson", "Beaudoin", "NC", "781 Houston St.", null, "28732" },
                    { 61, "Gatlinburg", "vigila23@hotmail.com", "Adam", "Vigil", "TN", "801 Chestnut Ave.", null, "37738" },
                    { 88, "Asheville", "tommyvlexington@mail.com", "Thomas", "Venable", "NC", "513 Morningside Dr.", null, "28715" },
                    { 89, "Knoxville", "bivinsv88@gmail.com", "Victor", "Bivins", "TN", "986 Central Rd.", "Apt. 211", "37918" },
                    { 92, "Knoxville", "leftwichbob19@gmail.com", "Bobby", "Leftwich", "TN", "1876 McClaughlin St.", null, "37918" },
                    { 95, "Gatlinburg", "musefamily@hotmail.com", "Antonio", "Muse", "TN", "2136 Rockbridge Way", null, "37738" },
                    { 97, "Knoxville", "bottomsnick12@gmail.com", "Nicholas", "Bottoms", "TN", "7809 Red Hill Rd.", null, "37918" },
                    { 98, "Murfreesboro", "mendesd@gmail.com", "David", "Mendes", "TN", "891 Reagan St.", null, "37128" },
                    { 79, "Knoxville", "rtorres@mail.net", "Ramona", "Torres", "TN", "9543 Paxton Dr.", null, "37918" },
                    { 60, "Ashville", "tbradford3@mail.com", "Tiffany", "Bradford", "NC", "745 Davidson St.", null, "28715" },
                    { 58, "Murfreesboro", "joshieb@mail.com", "Joshua", "Botello", "TN", "704 Peyton St.", null, "37128" },
                    { 57, "Cherokee", "erniec53@live.com", "Ernest", "Cochrane", "NC", "9013 Main St.", null, "28719" },
                    { 11, "Murfreesboro", "tlock1212@hotmail.com", "Todd", "Lockard", "TN", "5634 Furnace Hill Rd.", null, "37130" },
                    { 13, "Gatlinburg", "drenee12@yahoo.com", "Renee", "Devlin", "TN", "739 Birch Ave.", null, "37138" },
                    { 15, "Murfreesboro", "naturelover@rockbridge.net", "Justin", "Knighton", "TN", "513 Forest Ave.", null, "37128" },
                    { 20, "Gatlinburg", "rockbridgeoutdoors@mail.net", "Rockbridge", "Outdoors", "TN", "8913 Stagecoach Rd.", null, "37738" },
                    { 23, "Knoxville", "sherryfamily@mail.com", "Craig", "Sherry", "TN", "909 Cedar Ave.", null, "37918" },
                    { 25, "Gatlinburg", "canoemaster@hotmail.com", "Jeff", "Reichert", "TN", "4398 Old Allegheny Cir.", "Apt. 8", "37138" },
                    { 30, "Gatlinburg", "storminnorman@hotmail.com", "Norman", "Hernandes", "TN", "12 Sycamore Ave. 6", null, "37728" },
                    { 32, "Gatlinburg", "masterhiker@hotmail.com", "Stanley", "Calhoun", "TN", "590 Gibbs St.", null, "37738" },
                    { 27, "Murfreesboro", "kathyware22@yahoo.com", "Kathryn", "Ware", "TN", "324 Fuller St.", null, "37128" },
                    { 36, "Knoxville", "lizhazelwood@aol.com", "Elizabeth", "Hazelwood", "TN", "897 Cypress Ave.", null, "37918" },
                    { 40, "Asheville", "bridgetc@rockbridge.net", "Bridget", "Crozier", "NC", "601 Walker St.", null, "28715" },
                    { 41, "Cherokee", "mgmt@grassrootsrec.com", "Grassroots", "Recreation", "NC", "16 Rockfish School Ln.", null, "28719" },
                    { 42, "Gatlinburg", "mattmetz@gmail.com", "Matthew", "Metz", "TN", "2385 Mill St.", null, "37738" },
                    { 50, "Cherokee", "appoutfitters@gmail.com", "Appalachian", "Outfitters", "NC", "9823 Whitehill Rd.", "Suite A", "37130" },
                    { 52, "Ashville", "rogerfeliciano12@rockbridge.net", "Roger", "Feliciano", "NC", "8341 Maury River Rd.", null, "28732" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Email", "FirstName", "LastName", "State", "Street1", "Street2", "ZIP" },
                values: new object[,]
                {
                    { 55, "Gatlinburg", "johnnylovesnature@gmail.com", "Johnny", "Driggers", "TN", "6783 Allegheny Dr.", null, "37738" },
                    { 34, "Cherokee", "aliciamoorehead121@aol.com", "Alicia", "Moorehead", "NC", "643 Summit St.", null, "37738" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Commission", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 5701, 0.08m, "Lori", "Kish", "Seller" },
                    { 1063, 0.05m, "Josh", "Williams", "Manager" },
                    { 1492, 0.08m, "Nathan", "Bussell", "Buyer/Seller" },
                    { 3325, 0.065m, "Brandy", "Chaffi", "Buyer/Seller" },
                    { 6795, 0.07m, "Tony", "Gregg", "Seller" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Cost", "Name", "Price" },
                values: new object[,]
                {
                    { 3161, 283, 80.00m, "Mountainsmtih Lookout 45", 159.00m },
                    { 9398, 729, 300.00m, "Salomon BBR 7.9", 599.95m },
                    { 1318, 729, 280.00m, "Rossignol Avenger 76 Carbon", 559.96m },
                    { 8148, 685, 240.00m, "Rossignol Synergy Sensor 100", 479.95m },
                    { 6195, 685, 247.5m, "Tecnica USA Agent 80", 495.00m },
                    { 5284, 685, 175.00m, "Salomon Quest 8", 349.99m },
                    { 1662, 685, 200.00m, "Lange Concept 9", 399.95m },
                    { 5909, 477, 150.00m, "Kelty Buttress 6", 299.95m },
                    { 4706, 477, 275.00m, "Marmot Thor 3P", 550.00m },
                    { 3410, 477, 225.00m, "Sierra Designs Convert 2", 449.95m },
                    { 2395, 477, 230.00m, "Sierra Designs Lightning XT4", 459.95m },
                    { 1327, 477, 200.00m, "Mountain Safety Research Mutha Hubba", 399.95m },
                    { 3486, 729, 362.5m, "K2 Shockwave", 725.00m },
                    { 7614, 410, 210.00m, "Sierra Designs Vapor 15", 419.95m },
                    { 4563, 410, 185.00m, "The North Face Nebula", 369.00m },
                    { 1299, 410, 125.00m, "Sierra Designs Pyro 15", 249.95m },
                    { 7931, 320, 360.00m, "Specialized Rockhopper", 720.00m },
                    { 7816, 320, 1375.00m, "Trek Ticket Signature", 2749.99m },
                    { 4295, 320, 2300.00m, "Cannondale Claymore 2", 4599.00m },
                    { 2342, 320, 465.00m, "GT Ruckus DJ 2.0", 929.00m },
                    { 9887, 283, 94.50m, "Mountainsmith Apex 75", 189.00m },
                    { 7571, 283, 60.00m, "Kelty Yukon 48", 119.95m },
                    { 4978, 283, 45.00m, "Kelty Shrike 32", 89.95m },
                    { 4809, 283, 125.00m, "The North Face El Lobo 60", 249.00m },
                    { 9034, 410, 154.50m, "The North Face Dark Star", 309.00m }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "EmployeeId", "PurchaseDate" },
                values: new object[,]
                {
                    { 2034, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2033, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2032, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2027, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2030, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2025, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2026, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2035, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2031, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2036, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2044, 1492, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2038, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2039, 3325, new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2043, 1492, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2042, 1492, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2041, 1492, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2040, 1492, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "EmployeeId", "PurchaseDate" },
                values: new object[,]
                {
                    { 2028, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2037, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2029, 3325, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "EmployeeId", "SaleDate", "SaleTime" },
                values: new object[,]
                {
                    { 1081, 75, 3325, new DateTime(2020, 10, 18, 19, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 19, 38, 0, 0, DateTimeKind.Unspecified) },
                    { 1080, 11, 3325, new DateTime(2020, 10, 18, 13, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1062, 92, 6795, new DateTime(2020, 10, 8, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 17, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 1071, 74, 5701, new DateTime(2020, 10, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1072, 97, 5701, new DateTime(2020, 10, 15, 18, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 18, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1075, 98, 5701, new DateTime(2020, 10, 16, 15, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 15, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 1079, 82, 5701, new DateTime(2020, 10, 17, 13, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 1054, 23, 6795, new DateTime(2020, 10, 6, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1055, 61, 6795, new DateTime(2020, 10, 6, 12, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 12, 47, 0, 0, DateTimeKind.Unspecified) },
                    { 1057, 30, 6795, new DateTime(2020, 10, 7, 13, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 1058, 69, 6795, new DateTime(2020, 10, 7, 13, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1059, 69, 6795, new DateTime(2020, 10, 7, 14, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 14, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 1060, 66, 6795, new DateTime(2020, 10, 7, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 17, 38, 0, 0, DateTimeKind.Unspecified) },
                    { 1078, 23, 3325, new DateTime(2020, 10, 17, 13, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 1083, 86, 3325, new DateTime(2020, 10, 18, 19, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 19, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 1068, 79, 3325, new DateTime(2020, 10, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1074, 32, 1492, new DateTime(2020, 10, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1063, 70, 3325, new DateTime(2020, 10, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1052, 64, 1492, new DateTime(2020, 10, 5, 11, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 11, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1053, 58, 1492, new DateTime(2020, 10, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1061, 40, 1492, new DateTime(2020, 10, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1064, 88, 1492, new DateTime(2020, 10, 11, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 17, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1066, 60, 1492, new DateTime(2020, 10, 12, 13, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 1067, 89, 1492, new DateTime(2020, 10, 13, 14, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 14, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 1065, 25, 3325, new DateTime(2020, 10, 11, 20, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 20, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 1069, 34, 1492, new DateTime(2020, 10, 13, 19, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 19, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 1073, 36, 1492, new DateTime(2020, 10, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 12, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1082, 92, 6795, new DateTime(2020, 10, 18, 19, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 19, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1076, 13, 1492, new DateTime(2020, 10, 16, 18, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 18, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 1077, 27, 1492, new DateTime(2020, 10, 16, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1051, 61, 3325, new DateTime(2020, 10, 4, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1056, 78, 3325, new DateTime(2020, 10, 6, 13, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 13, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 1070, 15, 1492, new DateTime(2020, 10, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1084, 70, 6795, new DateTime(2020, 10, 18, 19, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(1899, 12, 30, 19, 55, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PurchaseItems",
                columns: new[] { "ItemId", "PurchaseId", "PurchaseQty" },
                values: new object[,]
                {
                    { 2395, 2040, 3 },
                    { 3410, 2026, 3 },
                    { 7614, 2026, 3 },
                    { 4978, 2027, 3 },
                    { 5909, 2027, 3 },
                    { 7571, 2027, 3 },
                    { 6195, 2028, 5 },
                    { 1662, 2029, 5 },
                    { 1327, 2030, 3 },
                    { 4563, 2031, 3 },
                    { 2395, 2026, 4 },
                    { 4809, 2031, 3 },
                    { 4706, 2032, 4 },
                    { 1318, 2033, 2 },
                    { 8148, 2033, 4 },
                    { 3486, 2034, 6 },
                    { 9398, 2035, 2 },
                    { 4295, 2036, 3 },
                    { 2342, 2037, 3 },
                    { 7816, 2038, 4 },
                    { 7816, 2039, 6 },
                    { 9034, 2031, 3 },
                    { 1299, 2025, 2 },
                    { 5284, 2035, 2 },
                    { 3161, 2025, 3 },
                    { 9887, 2025, 10 },
                    { 6195, 2041, 3 },
                    { 4563, 2042, 3 },
                    { 3486, 2043, 10 },
                    { 3161, 2044, 3 }
                });

            migrationBuilder.InsertData(
                table: "SaleItems",
                columns: new[] { "ItemId", "SaleId", "SaleQtySold" },
                values: new object[,]
                {
                    { 9887, 1080, 1 },
                    { 9887, 1081, 2 },
                    { 1318, 1083, 1 },
                    { 3486, 1083, 1 },
                    { 5284, 1083, 1 },
                    { 9034, 1083, 1 },
                    { 7816, 1071, 1 },
                    { 2395, 1072, 1 },
                    { 3486, 1080, 1 },
                    { 4809, 1072, 1 },
                    { 5284, 1079, 1 },
                    { 2395, 1054, 1 }
                });

            migrationBuilder.InsertData(
                table: "SaleItems",
                columns: new[] { "ItemId", "SaleId", "SaleQtySold" },
                values: new object[,]
                {
                    { 4563, 1054, 1 },
                    { 4809, 1054, 1 },
                    { 3410, 1055, 1 },
                    { 7614, 1055, 1 },
                    { 1327, 1057, 1 },
                    { 1299, 1058, 2 },
                    { 7571, 1058, 1 },
                    { 6195, 1059, 1 },
                    { 1318, 1060, 1 },
                    { 6195, 1060, 1 },
                    { 3161, 1062, 1 },
                    { 3161, 1075, 1 },
                    { 1318, 1080, 1 },
                    { 9887, 1065, 3 },
                    { 5909, 1068, 1 },
                    { 7816, 1077, 1 },
                    { 4706, 1076, 1 },
                    { 9398, 1074, 1 },
                    { 1662, 1074, 1 },
                    { 4809, 1073, 1 },
                    { 4563, 1070, 1 },
                    { 2395, 1070, 1 },
                    { 1662, 1069, 1 },
                    { 7816, 1067, 2 },
                    { 7816, 1066, 1 },
                    { 4295, 1064, 3 },
                    { 2342, 1061, 1 },
                    { 8148, 1053, 1 },
                    { 3486, 1053, 1 },
                    { 6195, 1052, 2 },
                    { 3161, 1082, 1 },
                    { 3486, 1052, 5 },
                    { 4706, 1051, 1 },
                    { 2342, 1056, 1 },
                    { 6195, 1063, 1 },
                    { 9398, 1063, 1 },
                    { 1662, 1065, 1 },
                    { 8148, 1065, 1 },
                    { 4978, 1078, 1 },
                    { 3486, 1084, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_ItemId",
                table: "PurchaseItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_EmployeeId",
                table: "Purchases",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItems_SaleId",
                table: "SaleItems",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseItems");

            migrationBuilder.DropTable(
                name: "SaleItems");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
