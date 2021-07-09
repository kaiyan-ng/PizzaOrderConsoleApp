using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderProject.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 25,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 0, 55, 54, 300, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Order_Id", "Crust_Id", "Customer_Id", "Order_Date_And_Time", "Order_Status", "Pizza_Id", "Topping_Id", "Topping_Id2", "Total_Amount" },
                values: new object[] { 27, 3, 20, new DateTime(2021, 6, 19, 0, 55, 54, 303, DateTimeKind.Local).AddTicks(1457), "Order Completed", 2, 8, 8, 32f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 25,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 0, 52, 36, 582, DateTimeKind.Local).AddTicks(2688));
        }
    }
}
