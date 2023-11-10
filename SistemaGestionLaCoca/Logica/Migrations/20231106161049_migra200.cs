using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logica.Migrations
{
    /// <inheritdoc />
    public partial class migra200 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministradorID",
                table: "Turnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_AdministradorID",
                table: "Turnos",
                column: "AdministradorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Administradores_AdministradorID",
                table: "Turnos",
                column: "AdministradorID",
                principalTable: "Administradores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Administradores_AdministradorID",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_AdministradorID",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "AdministradorID",
                table: "Turnos");
        }
    }
}
