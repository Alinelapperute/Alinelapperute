using Microsoft.EntityFrameworkCore.Migrations;

namespace Competition_WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    titulo = table.Column<string>(nullable: true),
                    nota = table.Column<double>(nullable: false),
                    ano = table.Column<int>(nullable: false),
                    urlImagem = table.Column<string>(nullable: true),
                    Jogosid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Jogo_Jogo_Jogosid",
                        column: x => x.Jogosid,
                        principalTable: "Jogo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Jogo",
                columns: new[] { "id", "Jogosid", "ano", "nota", "titulo", "urlImagem" },
                values: new object[] { "/nintendo-64/the-legend-of-zelda-ocarina-of-time", null, 1998, 99.900000000000006, "The Legend of Zelda: Ocarina of Time (N64)", "https://l3-processoseletivo.azurewebsites.net/api/CapaJogo/nintendo-64/the-legend-of-zelda-ocarina-of-time" });

            migrationBuilder.InsertData(
                table: "Jogo",
                columns: new[] { "id", "Jogosid", "ano", "nota", "titulo", "urlImagem" },
                values: new object[] { "/playstation/tony-hawks-pro-skater-2", null, 2000, 98.900000000000006, "Tony Hawk's Pro Skater 2 (PS)", "https://l3-processoseletivo.azurewebsites.net/api/CapaJogo/playstation/tony-hawks-pro-skater-2" });

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_Jogosid",
                table: "Jogo",
                column: "Jogosid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}
