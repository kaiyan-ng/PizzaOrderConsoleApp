using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderProject.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order_Date",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Order_Time",
                table: "Orders",
                newName: "Order_Date_And_Time");

            migrationBuilder.AddColumn<int>(
                name: "Topping_Id2",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topping_Id2",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Order_Date_And_Time",
                table: "Orders",
                newName: "Order_Time");

            migrationBuilder.AddColumn<DateTime>(
                name: "Order_Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
