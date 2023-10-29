using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logica.Migrations
{
    /// <inheritdoc />
    public partial class migra10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElementoCancha_Elementos_ElementoID",
                table: "ElementoCancha");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Elementos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ElementoID",
                table: "ElementoCancha",
                newName: "ElementoId");

            migrationBuilder.RenameIndex(
                name: "IX_ElementoCancha_ElementoID",
                table: "ElementoCancha",
                newName: "IX_ElementoCancha_ElementoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ElementoCancha_Elementos_ElementoId",
                table: "ElementoCancha",
                column: "ElementoId",
                principalTable: "Elementos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElementoCancha_Elementos_ElementoId",
                table: "ElementoCancha");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Elementos",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ElementoId",
                table: "ElementoCancha",
                newName: "ElementoID");

            migrationBuilder.RenameIndex(
                name: "IX_ElementoCancha_ElementoId",
                table: "ElementoCancha",
                newName: "IX_ElementoCancha_ElementoID");

            migrationBuilder.AddForeignKey(
                name: "FK_ElementoCancha_Elementos_ElementoID",
                table: "ElementoCancha",
                column: "ElementoID",
                principalTable: "Elementos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
