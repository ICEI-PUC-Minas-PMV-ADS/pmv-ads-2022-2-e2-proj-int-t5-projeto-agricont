using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriCont.Migrations
{
    public partial class Ag06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Informaticas_Empresas_EmpresaId",
                table: "Informaticas");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Informaticas");

            migrationBuilder.DropColumn(
                name: "NomeSeguradora",
                table: "Informaticas");

            migrationBuilder.RenameColumn(
                name: "penhora",
                table: "Informaticas",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "NumeroNotaFiscal",
                table: "Informaticas",
                newName: "NumNotaFiscal");

            migrationBuilder.RenameColumn(
                name: "NumeroApolice",
                table: "Informaticas",
                newName: "DescricaoProduto");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorSeguro",
                table: "Informaticas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorProduto",
                table: "Informaticas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDepreciacao",
                table: "Informaticas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "MotivoBaixa",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManutencaoSoftware",
                table: "Informaticas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Informaticas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoManutencao",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataManutencao",
                table: "Informaticas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "NumApolice",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seguradora",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Informaticas_Empresas_EmpresaId",
                table: "Informaticas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Informaticas_Empresas_EmpresaId",
                table: "Informaticas");

            migrationBuilder.DropColumn(
                name: "NumApolice",
                table: "Informaticas");

            migrationBuilder.DropColumn(
                name: "Seguradora",
                table: "Informaticas");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Informaticas",
                newName: "penhora");

            migrationBuilder.RenameColumn(
                name: "NumNotaFiscal",
                table: "Informaticas",
                newName: "NumeroNotaFiscal");

            migrationBuilder.RenameColumn(
                name: "DescricaoProduto",
                table: "Informaticas",
                newName: "NumeroApolice");

            migrationBuilder.AlterColumn<int>(
                name: "ValorSeguro",
                table: "Informaticas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "ValorProduto",
                table: "Informaticas",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "ValorDepreciacao",
                table: "Informaticas",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "MotivoBaixa",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManutencaoSoftware",
                table: "Informaticas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Informaticas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoManutencao",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataManutencao",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeSeguradora",
                table: "Informaticas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Informaticas_Empresas_EmpresaId",
                table: "Informaticas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }
    }
}
