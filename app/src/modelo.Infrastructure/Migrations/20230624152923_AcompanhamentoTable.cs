using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modelo.Infrastructure.Migrations
{
    public partial class AcompanhamentoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_Cliente",
                keyColumn: "Id",
                keyValue: "46abf27c-5186-4674-932d-67564975c3b9");

            migrationBuilder.DeleteData(
                table: "tb_Cliente",
                keyColumn: "Id",
                keyValue: "51a09f69-7cc0-41af-bfb2-cfbf85eb3c04");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "02b8b0f1-ec86-4e8a-984c-4468615e9c30");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "0337ef04-29aa-4590-aaf0-e77733cacc76");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "043a99da-38a6-4f4c-90c9-61a71090ad46");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "10676e35-6666-4308-9366-16001a5d8d83");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "2b19f2ea-9c2e-40f6-a6b1-cd0acba5aaac");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "351a0ed7-2dcb-410b-825d-4b8d2245ba58");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "3dea27a7-ccd7-4487-944d-98e11bf1e19e");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "48bda631-5795-49ae-929a-bb2c3154f2de");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "5626dda2-b1bb-43ef-be8a-1660d98294e8");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "621a2c3d-ad46-4919-9f90-c7b01c463a59");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "62d4cac5-72a9-4e52-abc5-199bdd458994");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "6e6764a2-3a06-4e6b-91e5-612f99f64b93");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "800376de-94ce-44b6-99e8-0023e3c1b233");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "8c769bfb-a9c0-467d-823a-f508fe303c16");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "93d1a2a7-b7a9-4c7d-851f-68f779717078");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "982b4b57-98e5-4364-ac82-966e50fde7c9");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "a261c5ba-4683-4c3e-9034-8022f932452c");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "b203715a-fb92-42be-87f0-5ad4818949e9");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "c870cb04-5519-4dd2-a54d-c915b237a3c5");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "f98f88b8-2fbf-4477-b46c-b5beb674137c");

            migrationBuilder.CreateTable(
                name: "tb_Acompanhamento",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Acompanhamento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_Cliente",
                columns: new[] { "Id", "Cpf", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { "957077a7-901c-46d9-bef8-fdea2a771b8e", "26521727788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blippi" },
                    { "aadfc2f4-3b68-4af8-bbda-31e61284603f", "08154831473", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juca" }
                });

            migrationBuilder.InsertData(
                table: "tb_Produto",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "Nome", "Valor" },
                values: new object[,]
                {
                    { "2648e622-6e02-4f55-a7af-ee7e752394ab", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Media", 7.00m },
                    { "34a143b3-6b13-4852-ab88-24b33e59164c", "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Pequena", 6.00m },
                    { "42e082ba-8785-4673-8836-9abb62f1d7ee", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Pequena", 5.00m },
                    { "4edc8734-e410-41a3-a2a1-675abcef99cd", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae Misto", 6.00m },
                    { "65ed6f56-e0fb-412f-ae8f-f0a9de8e0d64", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Baunilha", 6.00m },
                    { "679ae00f-ccda-449b-83dc-21158d1c1c94", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheeseburger", 9.00m },
                    { "71b67582-3371-4fc9-8139-b1fa218d8aab", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Grande", 9.00m },
                    { "72c6cae0-1e9d-470a-bc6b-ab369213cdb7", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamburguer", 8.00m },
                    { "7d826626-9076-4ec4-b8dd-e13e1985a139", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Baunilha", 3.00m },
                    { "8f76b2dd-887b-4c4d-a907-fd05cc7c2de1", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Chocolate", 6.00m },
                    { "9b0666a7-7264-4d28-a61e-364cdfb3c4da", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 4 unidades", 6.00m },
                    { "9b0bc2b8-8361-4203-9f51-f12c1aafafff", "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Grande", 10.00m },
                    { "ac0d32a1-763e-4039-bf31-2b75ef188089", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 8 unidades", 12.00m },
                    { "c90b8cbf-17b8-4ad5-9087-0c1201ce2460", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Tudo", 12.00m },
                    { "d6dcd390-bd61-4cee-a118-f72a1d793eb4", "5117243c-b007-49e8-9a30-842ec79248ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Media", 8.00m },
                    { "d7a6c31a-2648-487e-a9d0-194138a143d2", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Misto", 3.00m },
                    { "d805d566-f3e0-4f1d-aff7-7be281304bcd", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Bacon", 11.00m },
                    { "df53ad6a-0e12-4e1b-9806-234ac6c963bd", "cf412102-35da-43d8-9c3c-b72546104c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 12 unidades", 16.00m },
                    { "ec172d88-582a-4707-9cbc-af51e4c00698", "ada751db-8553-493f-b308-70bd29aed106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Salada", 10.00m },
                    { "f3dd62f0-992c-4d8c-ae10-623ccef9eab5", "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Chocolate", 3.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Acompanhamento");

            migrationBuilder.DeleteData(
                table: "tb_Cliente",
                keyColumn: "Id",
                keyValue: "957077a7-901c-46d9-bef8-fdea2a771b8e");

            migrationBuilder.DeleteData(
                table: "tb_Cliente",
                keyColumn: "Id",
                keyValue: "aadfc2f4-3b68-4af8-bbda-31e61284603f");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "2648e622-6e02-4f55-a7af-ee7e752394ab");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "34a143b3-6b13-4852-ab88-24b33e59164c");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "42e082ba-8785-4673-8836-9abb62f1d7ee");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "4edc8734-e410-41a3-a2a1-675abcef99cd");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "65ed6f56-e0fb-412f-ae8f-f0a9de8e0d64");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "679ae00f-ccda-449b-83dc-21158d1c1c94");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "71b67582-3371-4fc9-8139-b1fa218d8aab");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "72c6cae0-1e9d-470a-bc6b-ab369213cdb7");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "7d826626-9076-4ec4-b8dd-e13e1985a139");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "8f76b2dd-887b-4c4d-a907-fd05cc7c2de1");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "9b0666a7-7264-4d28-a61e-364cdfb3c4da");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "9b0bc2b8-8361-4203-9f51-f12c1aafafff");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "ac0d32a1-763e-4039-bf31-2b75ef188089");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "c90b8cbf-17b8-4ad5-9087-0c1201ce2460");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "d6dcd390-bd61-4cee-a118-f72a1d793eb4");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "d7a6c31a-2648-487e-a9d0-194138a143d2");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "d805d566-f3e0-4f1d-aff7-7be281304bcd");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "df53ad6a-0e12-4e1b-9806-234ac6c963bd");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "ec172d88-582a-4707-9cbc-af51e4c00698");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: "f3dd62f0-992c-4d8c-ae10-623ccef9eab5");

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
        }
    }
}
