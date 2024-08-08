using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class iksde : Migration
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
                    OrderCode = table.Column<int>(type: "int", nullable: false),
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
                    { 1, "123 Tech Street", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(559), "TechCorp", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(570) },
                    { 2, "456 Innovation Ave", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(572), "Innovate Inc.", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(572) },
                    { 3, "789 Alpha Road", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(574), "Alpha Co.", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(574) },
                    { 4, "321 Beta Blvd", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(575), "Beta Corp.", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(575) },
                    { 5, "654 Gamma Lane", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(577), "Gamma LLC", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(577) },
                    { 6, "987 Delta Drive", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(578), "Delta Ltd.", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(578) },
                    { 7, "147 Epsilon Parkway", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(579), "Epsilon Enterprises", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(580) },
                    { 8, "258 Zeta Avenue", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(581), "Zeta Solutions", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(581) },
                    { 9, "369 Eta Street", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(582), "Eta Inc.", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(583) },
                    { 10, "741 Theta Way", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(584), "Theta Technologies", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(584) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CompanyId", "CreatedDate", "FirstName", "LastName", "Password", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1096), "John", "Doe", "password1", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1097), 1001 },
                    { 2, "456 Oak St", 2, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1099), "Jane", "Doe", "password2", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1099), 1002 },
                    { 3, "789 Pine St", 3, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1101), "Jim", "Beam", "password3", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1101), 1003 },
                    { 4, "321 Maple St", 4, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1103), "Jack", "Daniels", "password4", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1103), 1004 },
                    { 5, "654 Elm St", 5, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1105), "Johnny", "Walker", "password5", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1105), 1005 },
                    { 6, "987 Cedar St", 5, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1106), "Tom", "Collins", "password6", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1107), 1006 },
                    { 7, "147 Birch St", 6, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1108), "Margarita", "Garcia", "password7", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1108), 1007 },
                    { 8, "258 Cherry St", 6, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1110), "Mojito", "Smith", "password8", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1110), 1008 },
                    { 9, "369 Walnut St", 7, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1112), "Mai", "Tai", "password9", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1112), 1009 },
                    { 10, "741 Ash St", 7, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1113), "Piña", "Colada", "password10", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(1114), 1010 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "OrderCode", "Price", "Quantity", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(784), 5001, 1000m, 10, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(785), 1 },
                    { 2, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(787), 5002, 2000m, 20, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(787), 1 },
                    { 3, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(789), 5003, 3000m, 30, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(789), 2 },
                    { 4, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(790), 5004, 4000m, 40, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(791), 2 },
                    { 5, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(792), 5005, 5000m, 50, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(792), 3 },
                    { 6, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(793), 5006, 6000m, 60, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(794), 3 },
                    { 7, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(795), 5007, 7000m, 70, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(795), 4 },
                    { 8, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(797), 5008, 8000m, 80, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(797), 4 },
                    { 9, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(798), 5009, 9000m, 90, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(799), 5 },
                    { 10, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(800), 5010, 10000m, 100, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(800), 5 }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "Id", "CreatedDate", "Name", "Quantity", "StockCode", "Type", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(967), "AAPL", 50, 10001, "Technology", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(968), 1 },
                    { 2, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(970), "GOOGL", 30, 10002, "Technology", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(971), 1 },
                    { 3, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(972), "MSFT", 20, 10003, "Technology", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(972), 2 },
                    { 4, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(974), "AMZN", 40, 10004, "Retail", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(974), 2 },
                    { 5, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(975), "TSLA", 60, 10005, "Automotive", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(976), 3 },
                    { 6, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(977), "FB", 70, 10006, "Social Media", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(977), 3 },
                    { 7, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(979), "NFLX", 80, 10007, "Entertainment", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(979), 4 },
                    { 8, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(980), "NVDA", 90, 10008, "Technology", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(981), 4 },
                    { 9, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(982), "AMD", 100, 10009, "Technology", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(982), 5 },
                    { 10, new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(984), "INTC", 110, 10010, "Technology", new DateTime(2024, 8, 8, 17, 22, 54, 342, DateTimeKind.Local).AddTicks(984), 5 }
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
