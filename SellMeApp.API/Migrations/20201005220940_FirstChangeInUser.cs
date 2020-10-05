using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SellMeApp.API.Migrations
{
    public partial class FirstChangeInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "UsersModel",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "UsersModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "UsersModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "UsersModel");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "UsersModel");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "UsersModel");
        }
    }
}
