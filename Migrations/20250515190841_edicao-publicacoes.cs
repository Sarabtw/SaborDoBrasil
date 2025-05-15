using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoBrasil.Migrations
{
    /// <inheritdoc />
    public partial class edicaopublicacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Publicacoes");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Publicacoes");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Publicacoes",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Publicacoes",
                newName: "Local");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Publicacoes",
                newName: "Imagem");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Publicacoes",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Publicacoes");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Publicacoes",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "Local",
                table: "Publicacoes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Imagem",
                table: "Publicacoes",
                newName: "Email");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Publicacoes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Publicacoes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
