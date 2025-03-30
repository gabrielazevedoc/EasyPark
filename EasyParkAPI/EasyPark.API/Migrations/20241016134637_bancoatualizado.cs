using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyParkAPI.Migrations
{
    /// <inheritdoc />
    public partial class bancoatualizado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Usuarios_UsuarioId",
                table: "Carros");

            migrationBuilder.RenameColumn(
                name: "IdVaga",
                table: "Vagas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.AddColumn<bool>(
                name: "Disponivel",
                table: "Vagas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataReserva",
                table: "Reservas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VagaId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Carros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VagaId",
                table: "Reservas",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Usuarios_UsuarioId",
                table: "Carros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Vagas_VagaId",
                table: "Reservas",
                column: "VagaId",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Usuarios_UsuarioId",
                table: "Carros");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Vagas_VagaId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_VagaId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "DataReserva",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vagas",
                newName: "IdVaga");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "Cpf");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Carros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Usuarios_UsuarioId",
                table: "Carros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
