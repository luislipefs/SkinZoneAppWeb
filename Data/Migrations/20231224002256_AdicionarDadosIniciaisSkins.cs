using Microsoft.EntityFrameworkCore.Migrations;
using SkinZoneAppWeb.Models;

#nullable disable

namespace SkinZoneAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisSkins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkinZoneDbContext();
            context.Skin.AddRange(ObterCargaInicialSkin());
            context.SaveChanges();

        }

        private IList<Skin> ObterCargaInicialSkin()
        {
            return new List<Skin>()
        {
            new Skin
            {
                Nome = "AK-47 Case Hardened",
                ImagemUri = "/images/ak_casehardened.png",
                Preco = 2000.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 1
            },
            new Skin
            {
                Nome = "AK-47 Gold Arabesque",
                ImagemUri = "/images/ak_gold.png",
                Preco = 5000.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(4),
                TipoId = 1
            },
            new Skin
            {
                Nome = "AK-47 RedLine",
                ImagemUri = "/images/ak_redline.png",
                Preco = 100.00,
                Desgaste = Skin.NivelDesgaste.TestadaEmCampo,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 1
            },
            new Skin
            {
                Nome = "AWP Dragon Lore",
                ImagemUri = "/images/awp_lore.png",
                Preco = 10000.00,
                Desgaste = Skin.NivelDesgaste.TestadaEmCampo,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(3),
                TipoId = 4
            },
            new Skin
            {
                Nome = "AWP The Prince",
                ImagemUri = "/images/awp_prince.png",
                Preco = 8000.00,
                Desgaste = Skin.NivelDesgaste.VeteranaDeGuerra,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(6),
                TipoId = 4
            },
            new Skin
            {
                Nome = "AWP Wild Fire",
                ImagemUri = "/images/awp_wildfire.png",
                Preco = 2000.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 4
            },
            new Skin
            {
                Nome = "M4A1-S Printstream",
                ImagemUri = "/images/m4a1_printstream.png",
                Preco = 500.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 3
            },
            new Skin
            {
                Nome = "M4A1-S Golden Coil",
                ImagemUri = "/images/m4a1_goldencoil.png",
                Preco = 400.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 3
            },
            new Skin
            {
                Nome = "M4A1-S Hyperbeast",
                ImagemUri = "/images/m4a1_hyperbeast.png",
                Preco = 100.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(7),
                TipoId = 3
            },
            new Skin
            {
                Nome = "Faca Butterfly Marble Fade",
                ImagemUri = "/images/butterfly_marblefade.png",
                Preco = 9000.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 8
            },
            new Skin
            {
                Nome = "Faca Falchion Doppler",
                ImagemUri = "/images/falchion_doppler.png",
                Preco = 2000.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(1),
                TipoId = 8
            },
            new Skin
            {
                Nome = "Faca Karambit Gamma Doppler",
                ImagemUri = "/images/karambit_gammadoppler.png",
                Preco = 7000.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now,
                TipoId = 8
            }
        };
        }
    }
}
