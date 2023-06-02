using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modelo.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_Categoria",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Categoria", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_WeatherForecast",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    TemperatureF = table.Column<int>(type: "integer", nullable: false),
                    Summary = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_WeatherForecast", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_Categoria",
                columns: new[] { "id", "Nome" },
                values: new object[,]
                {
                    { "049ac237-48d6-4d09-bb3d-e176a9463cab", "Lanche" },
                    { "48c89fc1-7329-4289-a7e2-9f6e0384868c", "Bebida" },
                    { "cdfe8985-4e69-453f-b569-46b626171563", "Acompanhamento" },
                    { "f413da09-f169-48bb-b294-c73f7f19e0fb", "Sobremesa" }
                });

            migrationBuilder.InsertData(
                table: "tb_Cliente",
                columns: new[] { "id", "CPF", "Nome" },
                values: new object[,]
                {
                    { "9d49d337-7afc-498b-9a90-d2529ef2e0e5", "34450347889", "Blippi" },
                    { "ee225698-7b19-4042-92f4-e492f880627b", "54252344881", "Juca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Categoria");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_WeatherForecast");
        }
    }
}
