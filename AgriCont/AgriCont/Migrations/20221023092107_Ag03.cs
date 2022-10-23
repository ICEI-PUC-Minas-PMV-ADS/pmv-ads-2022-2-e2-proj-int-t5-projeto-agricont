using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriCont.Migrations
{
    public partial class Ag03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ferramentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumNotaFiscal = table.Column<int>(type: "int", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorProduto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescricaoProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seguradora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumApolice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorSeguro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    DataBaixa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoBaixa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDepreciacao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataManutencao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DescricaoManutencao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComposicaoMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferramentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ferramentas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ferramentas_EmpresaId",
                table: "Ferramentas",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ferramentas");
        }
    }
}
