using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCOVID.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CovidDados",
                columns: table => new
                {
                    regiao = table.Column<string>(type: "text", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: true),
                    municipio = table.Column<string>(type: "text", nullable: true),
                    coduf = table.Column<int>(type: "integer", nullable: false),
                    codmun = table.Column<int>(type: "integer", nullable: false),
                    codRegiaoSaude = table.Column<int>(type: "integer", nullable: false),
                    nomeRegiaoSaude = table.Column<string>(type: "text", nullable: true),
                    data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    semanaEpi = table.Column<int>(type: "integer", nullable: false),
                    populacaoTCU2019 = table.Column<int>(type: "integer", nullable: true),
                    casosAcumulado = table.Column<int>(type: "integer", nullable: true),
                    casosNovos = table.Column<int>(type: "integer", nullable: true),
                    obitosAcumulado = table.Column<int>(type: "integer", nullable: true),
                    obitosNovos = table.Column<int>(type: "integer", nullable: true),
                    Recuperadosnovos = table.Column<int>(type: "integer", nullable: false),
                    emAcompanhamentoNovos = table.Column<int>(type: "integer", nullable: false),
                    interiorOUmetropolitana = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidDados");
        }
    }
}
