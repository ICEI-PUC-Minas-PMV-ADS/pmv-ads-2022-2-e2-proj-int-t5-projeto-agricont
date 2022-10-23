using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriCont.Migrations
{
    public partial class Agri02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Informaticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroNotaFiscal = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorProduto = table.Column<float>(type: "real", nullable: false),
                    NumeroApolice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorSeguro = table.Column<int>(type: "int", nullable: false),
                    NomeSeguradora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoManutencao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataManutencao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorDepreciacao = table.Column<float>(type: "real", nullable: false),
                    MotivoBaixa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataBaixa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManutencaoSoftware = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    penhora = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informaticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Informaticas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Informaticas_EmpresaId",
                table: "Informaticas",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informaticas");
        }
    }
}
