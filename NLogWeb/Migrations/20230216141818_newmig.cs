using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLogWeb.Migrations
{
    /// <inheritdoc />
    public partial class newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    AddOn = table.Column<DateTime>(type: "date", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "date", nullable: false),
                    RecStatus = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.StateId);
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "AddOn", "Department", "Email", "HireDate", "Job", "Name", "PhotoPath", "RecStatus", "Salary", "UpdateOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 16, 19, 48, 18, 93, DateTimeKind.Local).AddTicks(5580), 4, "amit@sircltech.com", new DateTime(2023, 2, 16, 19, 48, 18, 93, DateTimeKind.Local).AddTicks(5607), "Software", "Amit", "user.png", 1, 50000m, new DateTime(2023, 2, 16, 19, 48, 18, 93, DateTimeKind.Local).AddTicks(5600) },
                    { 2, new DateTime(2023, 2, 16, 19, 48, 18, 93, DateTimeKind.Local).AddTicks(5609), 3, "Sunil@sircltech.com", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardware", "Sunil", "user.png", 1, 40000m, new DateTime(2023, 2, 16, 19, 48, 18, 93, DateTimeKind.Local).AddTicks(5609) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "states");
        }
    }
}
