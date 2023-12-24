using Microsoft.EntityFrameworkCore.Migrations;
using SkinZoneAppWeb.Models;

#nullable disable

namespace SkinZoneAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisTipos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkinZoneDbContext();
            context.Tipo.AddRange(ObterCargaInicialTipo());
            context.SaveChanges();
        }

        private IList<Tipo> ObterCargaInicialTipo()
        {
            return new List<Tipo>()
            {
                new Tipo() { Descricao = "AK-47"},
                new Tipo() { Descricao = "M4A4" },
                new Tipo() { Descricao = "M4A1-S" },
                new Tipo() { Descricao = "AWP" },
                new Tipo() { Descricao = "GLOCK-18" },
                new Tipo() { Descricao = "USP-S" },
                new Tipo() { Descricao = "DESERT EAGLE" },
                new Tipo() { Descricao = "FACA" },
                new Tipo() { Descricao = "LUVA" }
            };
        }
    }
}
