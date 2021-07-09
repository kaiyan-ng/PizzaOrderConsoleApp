using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderProject.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 31, "beybladeslash2512", "levivsmonketbc" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 36, "Password", "JohnDoe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Date_Of_Birth", "Email_Address", "First_Name", "Gender", "Last_Name", "Phone_Number", "User_Id", "Zip_Code" },
                values: new object[] { 15, "23 Jalan Lokam, Singapore", new DateTime(1988, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "captainlevi@titanmail.com", "Darryl", "Male", "Chia", "94433168", 31, "537869" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Date_Of_Birth", "Email_Address", "First_Name", "Gender", "Last_Name", "Phone_Number", "User_Id", "Zip_Code" },
                values: new object[] { 20, "25, Tannery Lane #01-27", new DateTime(1972, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@email.com", "John", "Male", "Doe", "94825335", 36, "347786" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
