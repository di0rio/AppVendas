﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppVendasWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddTabelaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", maxLength: 100, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CadstroAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
