using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorFluxo.Infra.Data.Migrations
{
    public partial class RemovendoTabelaAnotacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anotacoes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anotacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProcesso = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotacoes", x => x.Id);
                    table.ForeignKey(
                        name: "IdProcesso",
                        column: x => x.IdProcesso,
                        principalTable: "Processos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anotacoes_Id",
                table: "Anotacoes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Anotacoes_IdProcesso",
                table: "Anotacoes",
                column: "IdProcesso");
        }
    }
}
