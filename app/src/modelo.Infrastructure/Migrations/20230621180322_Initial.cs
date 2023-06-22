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
                    Id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    CategoriaId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Produto_tb_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tb_Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_Pedido",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdutoId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tb_Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "tb_Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_Categoria",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobremesa" },
                    { "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bebida" },
                    { "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lanche" },
                    { "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acompanhamento" }
                });

            migrationBuilder.InsertData(
                table: "tb_Cliente",
                columns: new[] { "Id", "Cpf", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { "46abf27c-5186-4674-932d-67564975c3b9", "08154831473", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juca" },
                    { "51a09f69-7cc0-41af-bfb2-cfbf85eb3c04", "26521727788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blippi" }
                });

            migrationBuilder.InsertData(
                table: "tb_Produto",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "Nome", "Valor" },
                values: new object[,]
                {
                    { "02b8b0f1-ec86-4e8a-984c-4468615e9c30", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Baunilha", 6.00m },
                    { "0337ef04-29aa-4590-aaf0-e77733cacc76", "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Media", 8.00m },
                    { "043a99da-38a6-4f4c-90c9-61a71090ad46", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Chocolate", 6.00m },
                    { "10676e35-6666-4308-9366-16001a5d8d83", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheeseburger", 9.00m },
                    { "2b19f2ea-9c2e-40f6-a6b1-cd0acba5aaac", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 4 unidades", 6.00m },
                    { "351a0ed7-2dcb-410b-825d-4b8d2245ba58", "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Grande", 10.00m },
                    { "3dea27a7-ccd7-4487-944d-98e11bf1e19e", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Misto", 3.00m },
                    { "48bda631-5795-49ae-929a-bb2c3154f2de", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 12 unidades", 16.00m },
                    { "5626dda2-b1bb-43ef-be8a-1660d98294e8", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Chocolate", 3.00m },
                    { "621a2c3d-ad46-4919-9f90-c7b01c463a59", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Pequena", 5.00m },
                    { "62d4cac5-72a9-4e52-abc5-199bdd458994", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Media", 7.00m },
                    { "6e6764a2-3a06-4e6b-91e5-612f99f64b93", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Baunilha", 3.00m },
                    { "800376de-94ce-44b6-99e8-0023e3c1b233", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 8 unidades", 12.00m },
                    { "8c769bfb-a9c0-467d-823a-f508fe303c16", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Bacon", 11.00m },
                    { "93d1a2a7-b7a9-4c7d-851f-68f779717078", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Tudo", 12.00m },
                    { "982b4b57-98e5-4364-ac82-966e50fde7c9", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae Misto", 6.00m },
                    { "a261c5ba-4683-4c3e-9034-8022f932452c", "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Pequena", 6.00m },
                    { "b203715a-fb92-42be-87f0-5ad4818949e9", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamburguer", 8.00m },
                    { "c870cb04-5519-4dd2-a54d-c915b237a3c5", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Salada", 10.00m },
                    { "f98f88b8-2fbf-4477-b46c-b5beb674137c", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Grande", 9.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_CategoriaId",
                table: "tb_Pedido",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_ProdutoId",
                table: "tb_Pedido",
                column: "ProdutoId");

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
                name: "tb_Pedido");

            migrationBuilder.DropTable(
                name: "tb_Produto");

            migrationBuilder.DropTable(
                name: "tb_Categoria");
        }
    }
}
