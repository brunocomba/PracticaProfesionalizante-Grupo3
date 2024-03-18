using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logica.Migrations
{
    /// <inheritdoc />
    public partial class migra556 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deporte",
                table: "Canchas");

            migrationBuilder.RenameColumn(
                name: "Cantidad_Jugadores",
                table: "Canchas",
                newName: "DeporteID");

            migrationBuilder.CreateTable(
                name: "Deportes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cant_Jugadores = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deportes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canchas_DeporteID",
                table: "Canchas",
                column: "DeporteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Canchas_Deportes_DeporteID",
                table: "Canchas",
                column: "DeporteID",
                principalTable: "Deportes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canchas_Deportes_DeporteID",
                table: "Canchas");

            migrationBuilder.DropTable(
                name: "Deportes");

            migrationBuilder.DropIndex(
                name: "IX_Canchas_DeporteID",
                table: "Canchas");

            migrationBuilder.RenameColumn(
                name: "DeporteID",
                table: "Canchas",
                newName: "Cantidad_Jugadores");

            migrationBuilder.AddColumn<string>(
                name: "Deporte",
                table: "Canchas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
