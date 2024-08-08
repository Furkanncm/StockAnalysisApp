using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6538), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7099), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7122), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7125), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7433), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7823), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7826), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7833), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7841), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7844), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7848), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 8, 8, 11, 16, 42, 61, DateTimeKind.Local).AddTicks(7852) });
        }
    }
}
