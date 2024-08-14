using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class StockCodeString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Stock",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3492), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3494), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3497), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3789), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3795), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3799), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3801), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3923), "10001", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3928), "10002", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3930), "10003", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3933), "10004", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3934), "10005", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3936), "10006", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3938), "10007", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3940), "10008", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3942), "10009", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3943), "10010", new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4064), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4072), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(4074) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StockCode",
                table: "Stock",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9563), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9566), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9569), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9935), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9942), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 8, 14, 10, 30, 31, 87, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(74), 10001, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(77), 10002, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(79), 10003, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(81), 10004, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(83), 10005, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(85), 10006, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(87), 10007, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(89), 10008, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(91), 10009, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "StockCode", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(93), 10010, new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(239), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(249), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 8, 14, 10, 30, 31, 88, DateTimeKind.Local).AddTicks(252) });
        }
    }
}
