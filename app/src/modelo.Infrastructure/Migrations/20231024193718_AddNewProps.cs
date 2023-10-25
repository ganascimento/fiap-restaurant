using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modelo.Infrastructure.Migrations
{
    public partial class AddNewProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_Cliente",
                keyColumn: "Id",
                keyValue: new Guid("7c416c9e-5816-4b02-a9b6-9992e09b6967"));

            migrationBuilder.DeleteData(
                table: "tb_Cliente",
                keyColumn: "Id",
                keyValue: new Guid("dc9e9abe-6c11-41c8-b86a-10d8af06ac95"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("12512d36-75ac-4792-b7e0-84bcedf8a6fb"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("31bfb7f1-9c1e-41ca-b5f1-956861ddf34a"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("4f97de7c-a2fa-4468-976d-7fcaddf2363e"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("68ac45b4-22fb-48c4-85dc-ce56d6ab887f"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("6bb34b1f-8b80-41ea-92c4-f2bad6fd953c"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("6dc89609-8aeb-4454-bfeb-76671554f7b1"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("7309061c-1888-49b7-b367-6fd4153da7a8"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("951a8310-4c70-44aa-b041-5d669dc1fdbe"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("a80a6588-3128-4814-9e21-ec36555a5bfd"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("ac096413-5daf-44c0-9964-431e672f0e6d"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("acc5e53f-b4bd-4faf-9849-09e0995ecb2c"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("ad323b3c-a766-4302-9b23-d71f0edf6163"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("afc1c4d3-3ff1-4d0a-9bc8-7943e02b44fb"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("c4630a73-a9ea-4eb8-bd41-91fdea625f41"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("c5bc33a2-5168-4abf-9cc2-1ba8be2bc546"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("d8892d0a-12c0-4a4d-8826-659f4136b961"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("e8280926-0c3c-4522-91ea-f8d95ce2ab3d"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("edbb6701-b7a0-4c2e-a0ca-215c90040165"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("f0d33613-4e8d-41b5-9fc2-6af8f2b29d11"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("f9bb1e95-749a-4736-a7f8-8215c84721b4"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "tb_Pedido",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "tb_Cliente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_Produto",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("1a1a3a8a-e18e-4f3f-b8c7-d8d6cfbe82c4"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Chocolate", 3.00m },
                    { new Guid("1b95a886-6ad4-4c66-8545-54c18581e6d8"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamburguer", 8.00m },
                    { new Guid("284ed7d3-cf72-4ea0-a41e-6f965f381b5c"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 12 unidades", 16.00m },
                    { new Guid("2bf5af6c-a749-4b93-ad2b-953babc5839d"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Pequena", 5.00m },
                    { new Guid("5368d28c-f961-4602-aa79-8eb919409d5b"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Baunilha", 3.00m },
                    { new Guid("537cd5cb-7c63-497f-bf8f-936525917629"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae Misto", 6.00m },
                    { new Guid("62409637-121f-4562-87e9-560542d77d19"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Bacon", 11.00m },
                    { new Guid("74076fa6-84d1-4941-8142-73ae0af5d56e"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Baunilha", 6.00m },
                    { new Guid("8d7f1172-61c3-438a-a057-5f2061c1c3d2"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Grande", 9.00m },
                    { new Guid("926f17e3-14e4-40d4-8017-d964671b14e2"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Misto", 3.00m },
                    { new Guid("a1a04257-77ee-4563-a8d9-8c3021ba7c8b"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheeseburger", 9.00m },
                    { new Guid("a6687d79-89a7-4ca3-80b7-ca9a55fe067c"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 8 unidades", 12.00m },
                    { new Guid("c513fb2e-5dcf-4a31-9a58-a56a99d4f0db"), new Guid("5117243c-b007-49e8-9a30-842ec79248ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Pequena", 6.00m },
                    { new Guid("c5c25af9-0307-4ef0-b844-0bf51de8f649"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Salada", 10.00m },
                    { new Guid("ca1f0063-f2b1-43cd-875e-781d106cc4ea"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Tudo", 12.00m },
                    { new Guid("caf5eed0-329f-4e9d-8b7d-ac958989bef3"), new Guid("5117243c-b007-49e8-9a30-842ec79248ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Grande", 10.00m },
                    { new Guid("d5549cbc-2a02-4916-a6a5-f2ba3cd54e7a"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Media", 7.00m },
                    { new Guid("e7b3de7c-bce1-43b9-98bc-1430cd1ef5b5"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Chocolate", 6.00m },
                    { new Guid("f144ec42-3f01-4bda-a74b-ee6c599c5412"), new Guid("5117243c-b007-49e8-9a30-842ec79248ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Media", 8.00m },
                    { new Guid("f68c30ce-310c-4ef1-b6ce-073ee14d7f5a"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 4 unidades", 6.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_ClienteId",
                table: "tb_Pedido",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Pedido_tb_Cliente_ClienteId",
                table: "tb_Pedido",
                column: "ClienteId",
                principalTable: "tb_Cliente",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Pedido_tb_Cliente_ClienteId",
                table: "tb_Pedido");

            migrationBuilder.DropIndex(
                name: "IX_tb_Pedido_ClienteId",
                table: "tb_Pedido");

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("1a1a3a8a-e18e-4f3f-b8c7-d8d6cfbe82c4"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("1b95a886-6ad4-4c66-8545-54c18581e6d8"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("284ed7d3-cf72-4ea0-a41e-6f965f381b5c"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("2bf5af6c-a749-4b93-ad2b-953babc5839d"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("5368d28c-f961-4602-aa79-8eb919409d5b"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("537cd5cb-7c63-497f-bf8f-936525917629"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("62409637-121f-4562-87e9-560542d77d19"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("74076fa6-84d1-4941-8142-73ae0af5d56e"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("8d7f1172-61c3-438a-a057-5f2061c1c3d2"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("926f17e3-14e4-40d4-8017-d964671b14e2"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("a1a04257-77ee-4563-a8d9-8c3021ba7c8b"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("a6687d79-89a7-4ca3-80b7-ca9a55fe067c"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("c513fb2e-5dcf-4a31-9a58-a56a99d4f0db"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("c5c25af9-0307-4ef0-b844-0bf51de8f649"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("ca1f0063-f2b1-43cd-875e-781d106cc4ea"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("caf5eed0-329f-4e9d-8b7d-ac958989bef3"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("d5549cbc-2a02-4916-a6a5-f2ba3cd54e7a"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("e7b3de7c-bce1-43b9-98bc-1430cd1ef5b5"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("f144ec42-3f01-4bda-a74b-ee6c599c5412"));

            migrationBuilder.DeleteData(
                table: "tb_Produto",
                keyColumn: "Id",
                keyValue: new Guid("f68c30ce-310c-4ef1-b6ce-073ee14d7f5a"));

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "tb_Pedido");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tb_Cliente");

            migrationBuilder.InsertData(
                table: "tb_Cliente",
                columns: new[] { "Id", "Cpf", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { new Guid("7c416c9e-5816-4b02-a9b6-9992e09b6967"), "26521727788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blippi" },
                    { new Guid("dc9e9abe-6c11-41c8-b86a-10d8af06ac95"), "08154831473", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juca" }
                });

            migrationBuilder.InsertData(
                table: "tb_Produto",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("12512d36-75ac-4792-b7e0-84bcedf8a6fb"), new Guid("5117243c-b007-49e8-9a30-842ec79248ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Grande", 10.00m },
                    { new Guid("31bfb7f1-9c1e-41ca-b5f1-956861ddf34a"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 8 unidades", 12.00m },
                    { new Guid("4f97de7c-a2fa-4468-976d-7fcaddf2363e"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Baunilha", 6.00m },
                    { new Guid("68ac45b4-22fb-48c4-85dc-ce56d6ab887f"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae de Chocolate", 6.00m },
                    { new Guid("6bb34b1f-8b80-41ea-92c4-f2bad6fd953c"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Misto", 3.00m },
                    { new Guid("6dc89609-8aeb-4454-bfeb-76671554f7b1"), new Guid("5117243c-b007-49e8-9a30-842ec79248ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Pequena", 6.00m },
                    { new Guid("7309061c-1888-49b7-b367-6fd4153da7a8"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Pequena", 5.00m },
                    { new Guid("951a8310-4c70-44aa-b041-5d669dc1fdbe"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Media", 7.00m },
                    { new Guid("a80a6588-3128-4814-9e21-ec36555a5bfd"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Tudo", 12.00m },
                    { new Guid("ac096413-5daf-44c0-9964-431e672f0e6d"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamburguer", 8.00m },
                    { new Guid("acc5e53f-b4bd-4faf-9849-09e0995ecb2c"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Bacon", 11.00m },
                    { new Guid("ad323b3c-a766-4302-9b23-d71f0edf6163"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Baunilha", 3.00m },
                    { new Guid("afc1c4d3-3ff1-4d0a-9bc8-7943e02b44fb"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sundae Misto", 6.00m },
                    { new Guid("c4630a73-a9ea-4eb8-bd41-91fdea625f41"), new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sorverte de Chocolate", 3.00m },
                    { new Guid("c5bc33a2-5168-4abf-9cc2-1ba8be2bc546"), new Guid("5117243c-b007-49e8-9a30-842ec79248ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola Media", 8.00m },
                    { new Guid("d8892d0a-12c0-4a4d-8826-659f4136b961"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 4 unidades", 6.00m },
                    { new Guid("e8280926-0c3c-4522-91ea-f8d95ce2ab3d"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batata Frita Grande", 9.00m },
                    { new Guid("edbb6701-b7a0-4c2e-a0ca-215c90040165"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheeseburger", 9.00m },
                    { new Guid("f0d33613-4e8d-41b5-9fc2-6af8f2b29d11"), new Guid("cf412102-35da-43d8-9c3c-b72546104c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Nuggets 12 unidades", 16.00m },
                    { new Guid("f9bb1e95-749a-4736-a7f8-8215c84721b4"), new Guid("ada751db-8553-493f-b308-70bd29aed106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X Salada", 10.00m }
                });
        }
    }
}
