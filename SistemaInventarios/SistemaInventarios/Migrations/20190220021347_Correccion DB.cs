using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaInventarios.Migrations
{
    public partial class CorreccionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marca_MarcaId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "MarcaId",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marca_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marca_MarcaId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "MarcaId",
                table: "Productos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marca_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
