using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderProject.Migrations
{
    public partial class EighthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 25,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 21, 42, 28, 86, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 27,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 21, 42, 28, 87, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Order_Id", "Crust_Id", "Customer_Id", "Order_Date_And_Time", "Order_Status", "Pizza_Id", "Topping_Id", "Topping_Id2", "Total_Amount" },
                values: new object[] { 30, 1, 18, new DateTime(2021, 6, 19, 21, 42, 28, 87, DateTimeKind.Local).AddTicks(3078), "Order Completed", 5, 1, 4, 25f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 25,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 0, 55, 54, 300, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 27,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 0, 55, 54, 303, DateTimeKind.Local).AddTicks(1457));
        }
    }
}
