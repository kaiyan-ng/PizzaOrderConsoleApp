using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderProject.Migrations
{
    public partial class NinthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 25,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 21, 52, 0, 533, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 27,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 21, 52, 0, 534, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 30,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 21, 52, 0, 534, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 28, "b4a9574d", "izhazir" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Date_Of_Birth", "Email_Address", "First_Name", "Gender", "Last_Name", "Phone_Number", "User_Id", "Zip_Code" },
                values: new object[] { 12, "71 Jalan Jaskolski Hill", new DateTime(1942, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "reynolds.loma@hotmail.com", "Izhar Izuddin", "Male", "Raihan Nazir", "97627137", 28, "927511" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Order_Id", "Crust_Id", "Customer_Id", "Order_Date_And_Time", "Order_Status", "Pizza_Id", "Topping_Id", "Topping_Id2", "Total_Amount" },
                values: new object[] { 31, 2, 12, new DateTime(2021, 6, 19, 21, 52, 0, 534, DateTimeKind.Local).AddTicks(2987), "Order Completed", 1, 6, 1, 28f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Order_Id",
                keyValue: 30,
                column: "Order_Date_And_Time",
                value: new DateTime(2021, 6, 19, 21, 42, 28, 87, DateTimeKind.Local).AddTicks(3078));
        }
    }
}
