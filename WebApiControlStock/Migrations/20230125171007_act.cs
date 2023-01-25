using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiControlStock.Migrations
{
    public partial class act : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Categoria",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CategoriaId",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Categoria_CategoriaId",
                table: "Categoria",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Categoria_CategoriaId",
                table: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_CategoriaId",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Categoria");
        }
    }
}
