using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAnalyzeApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsersToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8611), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8857), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8860), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8862), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8864), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8865), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8867), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8869), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8903), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8905), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DeviceToken", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8907), null, new DateTime(2024, 8, 14, 14, 18, 54, 843, DateTimeKind.Local).AddTicks(8908) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceToken",
                table: "Users");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Stock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 8, 14, 11, 27, 23, 83, DateTimeKind.Local).AddTicks(3944) });

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
    }
}
