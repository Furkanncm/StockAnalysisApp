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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
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
                    OrderCode = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    { 1, "123 Tech Street", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6530), "TechCorp", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6531) },
                    { 2, "456 Innovation Ave", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6534), "Innovate Inc.", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6535) },
                    { 3, "789 Alpha Road", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6538), "Alpha Co.", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6539) },
                    { 4, "321 Beta Blvd", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6541), "Beta Corp.", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6542) },
                    { 5, "654 Gamma Lane", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6544), "Gamma LLC", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6545) },
                    { 6, "987 Delta Drive", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6547), "Delta Ltd.", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6548) },
                    { 7, "147 Epsilon Parkway", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6550), "Epsilon Enterprises", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6551) },
                    { 8, "258 Zeta Avenue", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6553), "Zeta Solutions", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6553) },
                    { 9, "369 Eta Street", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6556), "Eta Inc.", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6557) },
                    { 10, "741 Theta Way", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6559), "Theta Technologies", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6560) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CompanyId", "CreatedDate", "FirstName", "LastName", "Password", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7816), "John", "Doe", "password1", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7818), 1001 },
                    { 2, "456 Oak St", 2, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7823), "Jane", "Doe", "password2", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7824), 1002 },
                    { 3, "789 Pine St", 3, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7826), "Jim", "Beam", "password3", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7827), 1003 },
                    { 4, "321 Maple St", 4, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7829), "Jack", "Daniels", "password4", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7830), 1004 },
                    { 5, "654 Elm St", 5, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7833), "Johnny", "Walker", "password5", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7834), 1005 },
                    { 6, "987 Cedar St", 5, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7837), "Tom", "Collins", "password6", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7838), 1006 },
                    { 7, "147 Birch St", 6, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7841), "Margarita", "Garcia", "password7", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7842), 1007 },
                    { 8, "258 Cherry St", 6, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7844), "Mojito", "Smith", "password8", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7845), 1008 },
                    { 9, "369 Walnut St", 7, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7848), "Mai", "Tai", "password9", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7849), 1009 },
                    { 10, "741 Ash St", 7, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7851), "Piña", "Colada", "password10", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7852), 1010 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "OrderCode", "Price", "Quantity", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7099), 5001, 1000m, 10, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7101), 1 },
                    { 2, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7105), 5002, 2000m, 20, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7106), 1 },
                    { 3, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7109), 5003, 3000m, 30, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7110), 2 },
                    { 4, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7112), 5004, 4000m, 40, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7113), 2 },
                    { 5, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7115), 5005, 5000m, 50, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7116), 3 },
                    { 6, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7119), 5006, 6000m, 60, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7119), 3 },
                    { 7, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7122), 5007, 7000m, 70, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7122), 4 },
                    { 8, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7125), 5008, 8000m, 80, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7126), 4 },
                    { 9, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7128), 5009, 9000m, 90, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7129), 5 },
                    { 10, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7131), 5010, 10000m, 100, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7132), 5 }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "Id", "CreatedDate", "Name", "Quantity", "StockCode", "Type", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7409), "AAPL", 50, 10001, "Technology", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7410), 1 },
                    { 2, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7413), "GOOGL", 30, 10002, "Technology", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7414), 1 },
                    { 3, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7416), "MSFT", 20, 10003, "Technology", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7417), 2 },
                    { 4, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7420), "AMZN", 40, 10004, "Retail", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7420), 2 },
                    { 5, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7423), "TSLA", 60, 10005, "Automotive", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7424), 3 },
                    { 6, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7426), "FB", 70, 10006, "Social Media", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7427), 3 },
                    { 7, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7430), "NFLX", 80, 10007, "Entertainment", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7430), 4 },
                    { 8, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7433), "NVDA", 90, 10008, "Technology", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7434), 4 },
                    { 9, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7436), "AMD", 100, 10009, "Technology", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7437), 5 },
                    { 10, new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7439), "INTC", 110, 10010, "Technology", new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7440), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_UserId",
                table: "Stock",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");
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
