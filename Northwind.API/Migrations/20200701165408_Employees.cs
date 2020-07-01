using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.API.Migrations
{
    public partial class Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TitleOfCourtesy = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(24)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    Photo = table.Column<byte[]>(type: "image", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
