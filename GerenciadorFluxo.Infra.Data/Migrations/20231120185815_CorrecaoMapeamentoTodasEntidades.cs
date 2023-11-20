using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorFluxo.Infra.Data.Migrations
{
    public partial class CorrecaoMapeamentoTodasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fluxos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Fluxo destinado para o controle dos processos de vendas", "Fluxo de vendas" });

            migrationBuilder.InsertData(
                table: "Fluxos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Fluxo destinado para o controle dos processos de people", "Fluxo de people" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fluxos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fluxos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
