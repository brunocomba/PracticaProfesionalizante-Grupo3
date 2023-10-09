using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logica.Migrations
{
    /// <inheritdoc />
    public partial class migra4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elementos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elementos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ElementoCancha",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanchaID = table.Column<int>(type: "int", nullable: false),
                    ElementoID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementoCancha", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ElementoCancha_Canchas_CanchaID",
                        column: x => x.CanchaID,
                        principalTable: "Canchas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementoCancha_Elementos_ElementoID",
                        column: x => x.ElementoID,
                        principalTable: "Elementos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementoCancha_CanchaID",
                table: "ElementoCancha",
                column: "CanchaID");

            migrationBuilder.CreateIndex(
                name: "IX_ElementoCancha_ElementoID",
                table: "ElementoCancha",
                column: "ElementoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementoCancha");

            migrationBuilder.DropTable(
                name: "Elementos");
        }
    }
}
