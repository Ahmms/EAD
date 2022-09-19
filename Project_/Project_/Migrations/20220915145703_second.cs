using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "UserData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "UserData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "AdsData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AdsData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "AdsData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AdsData",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "UserData");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserData");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "UserData");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UserData");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "AdsData");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AdsData");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "AdsData");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AdsData");
        }
    }
}
