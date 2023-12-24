using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkinZoneAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoSkinTipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Skin",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skin_TipoId",
                table: "Skin",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skin_Tipo_TipoId",
                table: "Skin",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "TipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skin_Tipo_TipoId",
                table: "Skin");

            migrationBuilder.DropIndex(
                name: "IX_Skin_TipoId",
                table: "Skin");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Skin");
        }
    }
}
