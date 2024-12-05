﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alikabook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addLengthWidthHeightPagesInBookInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "BookInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "BookInfos",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Length",
                table: "BookInfos",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "BookInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Width",
                table: "BookInfos",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 41,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 42,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 43,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 44,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 45,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 46,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 47,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 48,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 49,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 50,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 51,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 52,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 53,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 54,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 55,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 56,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 57,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 58,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 59,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 60,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 61,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 62,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 63,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 64,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 65,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 66,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 67,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 68,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 69,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 70,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 71,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 72,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 73,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 74,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 75,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 76,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 77,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 78,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 79,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 80,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 81,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 82,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 83,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 84,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 85,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 86,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 87,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 88,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 89,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 90,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 91,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 92,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 93,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 94,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 95,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 96,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 97,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 98,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 99,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 100,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 101,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 102,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 103,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 104,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 105,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 106,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 107,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 108,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 109,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 110,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 111,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 112,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 113,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 114,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 115,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 116,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 117,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 118,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 119,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 120,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 121,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 122,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 123,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 124,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 125,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 126,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 127,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 128,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 129,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 130,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 131,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 132,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 133,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 134,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 135,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 136,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 137,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 138,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 139,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 140,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 141,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 142,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 143,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 144,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 145,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 146,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 147,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 148,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 149,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 150,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 151,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 152,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 153,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 154,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 155,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 156,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 157,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 158,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 159,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 160,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 161,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 162,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 163,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 164,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 165,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 166,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 167,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 168,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 169,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 170,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 171,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 172,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 173,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 174,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 175,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 176,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 177,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "BookInfos",
                keyColumn: "BookId",
                keyValue: 178,
                columns: new[] { "Height", "Length", "Pages", "Width" },
                values: new object[] { null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "BookInfos");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "BookInfos");

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "BookInfos");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "BookInfos");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "BookInfos",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}