using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1403), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1719), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1723), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1725), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1934), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1947), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1949), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1956), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2114), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2117), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2119), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2121), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2126), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2132), new DateTime(2024, 8, 8, 13, 48, 45, 682, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCode",
                table: "Users",
                column: "UserCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_StockCode",
                table: "Stock",
                column: "StockCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderCode",
                table: "Orders",
                column: "OrderCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserCode",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Stock_StockCode",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderCode",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(581), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(593), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(596), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(601), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(602), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(604), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(833), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(955), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(961), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1077), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1081), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1085), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1166), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1168), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1170), new DateTime(2024, 8, 8, 13, 45, 58, 546, DateTimeKind.Local).AddTicks(1171) });
        }
    }
}
