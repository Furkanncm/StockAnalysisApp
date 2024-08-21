using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class fixCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8838), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9087), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9199), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9329), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9331), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9333), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9338), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 8, 21, 14, 16, 26, 167, DateTimeKind.Local).AddTicks(9342) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8231), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8233), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8238), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8240), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8783), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 8, 16, 14, 3, 7, 708, DateTimeKind.Local).AddTicks(8791) });
        }
    }
}
