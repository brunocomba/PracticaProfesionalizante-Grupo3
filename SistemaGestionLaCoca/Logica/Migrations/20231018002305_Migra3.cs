using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logica.Migrations
{
    /// <inheritdoc />
    public partial class Migra3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Canchas_Cancha_TurnoID",
                table: "Turnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Clientes_Cliente_TurnoID",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_Cliente_TurnoID",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "Reservado",
                table: "Turnos");

            migrationBuilder.RenameColumn(
                name: "Cliente_TurnoID",
                table: "Turnos",
                newName: "Condicion");

            migrationBuilder.RenameColumn(
                name: "Cancha_TurnoID",
                table: "Turnos",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Turnos_Cancha_TurnoID",
                table: "Turnos",
                newName: "IX_Turnos_ClienteID");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Canchas",
                newName: "Deporte");

            migrationBuilder.AddColumn<int>(
                name: "CanchaID",
                table: "Turnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Canchas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_CanchaID",
                table: "Turnos",
                column: "CanchaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Canchas_CanchaID",
                table: "Turnos",
                column: "CanchaID",
                principalTable: "Canchas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Clientes_ClienteID",
                table: "Turnos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Canchas_CanchaID",
                table: "Turnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Clientes_ClienteID",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_CanchaID",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "CanchaID",
                table: "Turnos");

            migrationBuilder.RenameColumn(
                name: "Condicion",
                table: "Turnos",
                newName: "Cliente_TurnoID");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Turnos",
                newName: "Cancha_TurnoID");

            migrationBuilder.RenameIndex(
                name: "IX_Turnos_ClienteID",
                table: "Turnos",
                newName: "IX_Turnos_Cancha_TurnoID");

            migrationBuilder.RenameColumn(
                name: "Deporte",
                table: "Canchas",
                newName: "Tipo");

            migrationBuilder.AddColumn<bool>(
                name: "Reservado",
                table: "Turnos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Precio",
                table: "Canchas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_Cliente_TurnoID",
                table: "Turnos",
                column: "Cliente_TurnoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Canchas_Cancha_TurnoID",
                table: "Turnos",
                column: "Cancha_TurnoID",
                principalTable: "Canchas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Clientes_Cliente_TurnoID",
                table: "Turnos",
                column: "Cliente_TurnoID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
