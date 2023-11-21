using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorFluxo.Infra.Data.Migrations
{
    public partial class ReferenciandoOsSubProcessos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Processos_IdProcessoSuperior",
                table: "Processos",
                column: "IdProcessoSuperior");

            migrationBuilder.AddForeignKey(
                name: "IdProcessoSuperior",
                table: "Processos",
                column: "IdProcessoSuperior",
                principalTable: "Processos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "IdProcessoSuperior",
                table: "Processos");

            migrationBuilder.DropIndex(
                name: "IX_Processos_IdProcessoSuperior",
                table: "Processos");
        }
    }
}
