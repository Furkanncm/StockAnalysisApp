using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserCode = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, computedColumnSql: "[Quantity]*[Price]"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockCode = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Tech Street", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9540), "TechCorp", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9554) },
                    { 2, "456 Innovation Ave", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9556), "Innovate Inc.", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9557) },
                    { 3, "789 Alpha Road", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9558), "Alpha Co.", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9558) },
                    { 4, "321 Beta Blvd", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9559), "Beta Corp.", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9560) },
                    { 5, "654 Gamma Lane", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9561), "Gamma LLC", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9562) },
                    { 6, "987 Delta Drive", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9563), "Delta Ltd.", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9564) },
                    { 7, "147 Epsilon Parkway", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9565), "Epsilon Enterprises", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9565) },
                    { 8, "258 Zeta Avenue", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9566), "Zeta Solutions", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9567) },
                    { 9, "369 Eta Street", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9568), "Eta Inc.", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9568) },
                    { 10, "741 Theta Way", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9569), "Theta Technologies", new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9570) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CompanyId", "CreatedDate", "FirstName", "LastName", "Password", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(232), "John", "Doe", "password1", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(232), 1001 },
                    { 2, "456 Oak St", 2, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(235), "Jane", "Doe", "password2", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(235), 1002 },
                    { 3, "789 Pine St", 3, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(237), "Jim", "Beam", "password3", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(237), 1003 },
                    { 4, "321 Maple St", 4, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(239), "Jack", "Daniels", "password4", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(240), 1004 },
                    { 5, "654 Elm St", 5, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(241), "Johnny", "Walker", "password5", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(241), 1005 },
                    { 6, "987 Cedar St", 5, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(243), "Tom", "Collins", "password6", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(243), 1006 },
                    { 7, "147 Birch St", 6, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(245), "Margarita", "Garcia", "password7", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(245), 1007 },
                    { 8, "258 Cherry St", 6, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(247), "Mojito", "Smith", "password8", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(247), 1008 },
                    { 9, "369 Walnut St", 7, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(249), "Mai", "Tai", "password9", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(250), 1009 },
                    { 10, "741 Ash St", 7, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(251), "Piña", "Colada", "password10", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(252), 1010 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "OrderCode", "Price", "Quantity", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9927), "5001", 1000m, 10, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9928), 1 },
                    { 2, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9931), "5002", 2000m, 20, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9931), 1 },
                    { 3, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9933), "5003", 3000m, 30, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9934), 2 },
                    { 4, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9935), "5004", 4000m, 40, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9935), 2 },
                    { 5, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9937), "5005", 5000m, 50, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9937), 3 },
                    { 6, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9939), "5006", 6000m, 60, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9939), 3 },
                    { 7, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9940), "5007", 7000m, 70, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9941), 4 },
                    { 8, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9942), "5008", 8000m, 80, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9943), 4 },
                    { 9, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9945), "5009", 9000m, 90, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9945), 5 },
                    { 10, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9946), "5010", 10000m, 100, new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9947), 5 }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "Id", "CreatedDate", "Name", "OrderCode", "Quantity", "StockCode", "Type", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(74), "AAPL", "5001", 50, 10001, "Technology", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(75), 1 },
                    { 2, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(77), "GOOGL", "5002", 30, 10002, "Technology", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(78), 1 },
                    { 3, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(79), "MSFT", "5003", 20, 10003, "Technology", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(80), 2 },
                    { 4, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(81), "AMZN", "5004", 40, 10004, "Retail", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(82), 2 },
                    { 5, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(83), "TSLA", "5005", 60, 10005, "Automotive", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(84), 3 },
                    { 6, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(85), "FB", "5006", 70, 10006, "Social Media", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(86), 3 },
                    { 7, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(87), "NFLX", "5007", 80, 10007, "Entertainment", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(87), 4 },
                    { 8, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(89), "NVDA", "5008", 90, 10008, "Technology", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(90), 4 },
                    { 9, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(91), "AMD", "5009", 100, 10009, "Technology", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(91), 5 },
                    { 10, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(93), "INTC", "5010", 110, 10010, "Technology", new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(93), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderCode",
                table: "Orders",
                column: "OrderCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_StockCode",
                table: "Stock",
                column: "StockCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_UserId",
                table: "Stock",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCode",
                table: "Users",
                column: "UserCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
