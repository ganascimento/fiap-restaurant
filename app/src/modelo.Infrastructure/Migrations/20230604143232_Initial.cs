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

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    CategoriaId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_Produto_tb_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tb_Categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_Categoria",
                columns: new[] { "id", "Nome" },
                values: new object[,]
                {
                    { "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sobremesa" },
                    { "5117243c-b007-49e8-9a30-842ec79248ae", "Bebida" },
                    { "ada751db-8553-493f-b308-70bd29aed106", "Lanche" },
                    { "cf412102-35da-43d8-9c3c-b72546104c72", "Acompanhamento" }
                });

            migrationBuilder.InsertData(
                table: "tb_Cliente",
                columns: new[] { "id", "CPF", "Nome" },
                values: new object[,]
                {
                    { "11583292-066e-4ba8-9417-fda84e2781f1", "54252344881", "Juca" },
                    { "3f41b1d4-7c76-4fed-b88a-721855912c70", "34450347889", "Blippi" }
                });

            migrationBuilder.InsertData(
                table: "tb_Produto",
                columns: new[] { "id", "CategoriaId", "Nome", "Valor" },
                values: new object[,]
                {
                    { "00830efc-97fc-4647-af7b-9a7f5643db11", "5117243c-b007-49e8-9a30-842ec79248ae", "Coca Cola Media", 8.00m },
                    { "023ecbe3-3a43-4ed2-9f0f-958fa1e72c3e", "ada751db-8553-493f-b308-70bd29aed106", "X Bacon", 11.00m },
                    { "110abdaa-716c-4728-ba22-9f8655d88b49", "ada751db-8553-493f-b308-70bd29aed106", "Hamburguer", 8.00m },
                    { "25898dc9-dc9d-43d6-9c24-7548f5ca1dc7", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sundae de Chocolate", 6.00m },
                    { "3ba8c219-8f0b-4fe1-ac28-d02f120d2ef2", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sorverte de Chocolate", 3.00m },
                    { "3cb9bb22-cd7a-4cb4-a89c-4c4d9c05a4f2", "cf412102-35da-43d8-9c3c-b72546104c72", "Chicken Nuggets 8 unidades", 12.00m },
                    { "423acf91-556f-4ce5-8e7d-50c1c01332ec", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sundae de Baunilha", 6.00m },
                    { "443a0adb-c99a-42dc-a0e0-96873c3737ef", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sorverte de Baunilha", 3.00m },
                    { "4ddd1974-0653-4163-bd8a-c73cb90d6f42", "cf412102-35da-43d8-9c3c-b72546104c72", "Batata Frita Grande", 9.00m },
                    { "5bd4fb4f-efa9-4ff3-897a-849ee0edf756", "ada751db-8553-493f-b308-70bd29aed106", "Cheeseburger", 9.00m },
                    { "7b88e08c-62af-4497-9b18-2f63b5b826b5", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sundae Misto", 6.00m },
                    { "8de550a8-694f-479a-8905-4e396a736123", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", "Sorverte de Misto", 3.00m },
                    { "90c625a3-9519-4d85-9723-27d2a626a2d8", "cf412102-35da-43d8-9c3c-b72546104c72", "Batata Frita Media", 7.00m },
                    { "b66dbe6c-00f9-4a08-bcd8-9f7bcd729c72", "5117243c-b007-49e8-9a30-842ec79248ae", "Coca Cola Grande", 10.00m },
                    { "ba6c112a-e218-4bc4-b093-659025b7ff20", "ada751db-8553-493f-b308-70bd29aed106", "X Salada", 10.00m },
                    { "c93f98d1-ecfa-4225-8249-e8939d491333", "cf412102-35da-43d8-9c3c-b72546104c72", "Batata Frita Pequena", 5.00m },
                    { "d474d3ee-1d34-4b7b-879a-d461f4c38312", "cf412102-35da-43d8-9c3c-b72546104c72", "Chicken Nuggets 12 unidades", 16.00m },
                    { "eefd47f7-db03-483f-9f02-5370c3c89dff", "5117243c-b007-49e8-9a30-842ec79248ae", "Coca Cola Pequena", 6.00m },
                    { "ef8497a2-b694-4f1b-9e98-2a350d8e3a53", "ada751db-8553-493f-b308-70bd29aed106", "X Tudo", 12.00m },
                    { "f72749bb-d658-4029-9c87-5a8e371b2b8f", "cf412102-35da-43d8-9c3c-b72546104c72", "Chicken Nuggets 4 unidades", 6.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Produto_CategoriaId",
                table: "tb_Produto",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Produto");

            migrationBuilder.DropTable(
                name: "tb_WeatherForecast");

            migrationBuilder.DropTable(
                name: "tb_Categoria");
        }
    }
}
