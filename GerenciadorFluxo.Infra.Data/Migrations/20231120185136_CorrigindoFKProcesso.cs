using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorFluxo.Infra.Data.Migrations
{
    public partial class CorrigindoFKProcesso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "IdFluxo",
                table: "Processos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Processos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_IdFluxo",
                table: "Processos",
                column: "IdFluxo");

            migrationBuilder.AddForeignKey(
                name: "IdFluxo",
                table: "Processos",
                column: "IdFluxo",
                principalTable: "Fluxos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "IdFluxo",
                table: "Processos");

            migrationBuilder.DropIndex(
                name: "IX_Processos_IdFluxo",
                table: "Processos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Processos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "IdFluxo",
                table: "Processos",
                column: "Id",
                principalTable: "Fluxos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}