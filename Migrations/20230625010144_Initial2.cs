using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Docentes_DocentesId",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "DocenteId",
                table: "Prestamos");

            migrationBuilder.AlterColumn<int>(
                name: "DocentesId",
                table: "Prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Docentes_DocentesId",
                table: "Prestamos",
                column: "DocentesId",
                principalTable: "Docentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Docentes_DocentesId",
                table: "Prestamos");

            migrationBuilder.AlterColumn<int>(
                name: "DocentesId",
                table: "Prestamos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DocenteId",
                table: "Prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Docentes_DocentesId",
                table: "Prestamos",
                column: "DocentesId",
                principalTable: "Docentes",
                principalColumn: "Id");
        }
    }
}
