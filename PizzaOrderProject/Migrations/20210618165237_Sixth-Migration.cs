using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderProject.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Order_Id", "Crust_Id", "Customer_Id", "Order_Date_And_Time", "Order_Status", "Pizza_Id", "Topping_Id", "Topping_Id2", "Total_Amount" },
                values: new object[] { 25, 2, 15, new DateTime(2021, 6, 19, 0, 52, 36, 582, DateTimeKind.Local).AddTicks(2688), "Order Completed", 1, 6, 2, 28f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 25);
        }
    }
}
