using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.API.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipVia = table.Column<int>(type: "int", nullable: false),
                    Freight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShipName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    ShipAddress = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    ShipCity = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    ShipRegion = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    ShipPostalCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ShipCountry = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
