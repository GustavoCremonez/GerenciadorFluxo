using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorFluxo.Infra.Data.Migrations
{
    public partial class CriacaoDasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluxos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluxos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFluxo = table.Column<int>(type: "int", nullable: false),
                    IdProcessoSuperior = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TipoProcesso = table.Column<byte>(type: "tinyint ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                    table.ForeignKey(
                        name: "IdFluxo",
                        column: x => x.IdFluxo,
                        principalTable: "Fluxos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Fluxos_Id",
                table: "Fluxos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_Id",
                table: "Processos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_IdFluxo",
                table: "Processos",
                column: "IdFluxo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anotacoes");

            migrationBuilder.DropTable(
                name: "Processos");

            migrationBuilder.DropTable(
                name: "Fluxos");
        }
    }
}
