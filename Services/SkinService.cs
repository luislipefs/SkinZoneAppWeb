using SkinZoneAppWeb.Models;

namespace SkinZoneAppWeb.Services
{
    public class SkinService : ISkinService
    {

        public SkinService()
            => CarregarListaInicial();

        private IList<Skin> _skins;

        private void CarregarListaInicial()
        {
            _skins = new List<Skin>()
        {
            new Skin
            {
                SkinId = 1,
                Nome = "AK-47 Case Hardened",
                ImagemUri = "/images/ak_casehardened.png",
                Preco = 2000.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            },
            new Skin
            {
                SkinId = 2,
                Nome = "AK-47 Gold Arabesque",
                ImagemUri = "/images/ak_gold.png",
                Preco = 5000.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(4)
            },
            new Skin
            {
                SkinId = 3,
                Nome = "AK-47 RedLine",
                ImagemUri = "/images/ak_redline.png",
                Preco = 100.00,
                Desgaste = Skin.NivelDesgaste.TestadaEmCampo,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            },
            new Skin
            {
                SkinId = 4,
                Nome = "AWP Dragon Lore",
                ImagemUri = "/images/awp_lore.png",
                Preco = 10000.00,
                Desgaste = Skin.NivelDesgaste.TestadaEmCampo,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(3)
            },
            new Skin
            {
                SkinId = 5,
                Nome = "AWP The Prince",
                ImagemUri = "/images/awp_prince.png",
                Preco = 8000.00,
                Desgaste = Skin.NivelDesgaste.VeteranaDeGuerra,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(6)
            },
            new Skin
            {
                SkinId = 6,
                Nome = "AWP Wild Fire",
                ImagemUri = "/images/awp_wildfire.png",
                Preco = 2000.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            },
            new Skin
            {
                SkinId = 7,
                Nome = "M4A1-S Printstream",
                ImagemUri = "/images/m4a1_printstream.png",
                Preco = 500.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            },
            new Skin
            {
                SkinId = 8,
                Nome = "M4A1-S Golden Coil",
                ImagemUri = "/images/m4a1_goldencoil.png",
                Preco = 400.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            },
            new Skin
            {
                SkinId = 9,
                Nome = "M4A1-S Hyperbeast",
                ImagemUri = "/images/m4a1_hyperbeast.png",
                Preco = 100.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(7)
            },
            new Skin
            {
                SkinId = 10,
                Nome = "Faca Butterfly Marble Fade",
                ImagemUri = "/images/butterfly_marblefade.png",
                Preco = 9000.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            },
            new Skin
            {
                SkinId = 11,
                Nome = "Faca Falchion Doppler",
                ImagemUri = "/images/falchion_doppler.png",
                Preco = 2000.00,
                Desgaste = Skin.NivelDesgaste.NovaDeFabrica,
                DisponivelParaRetirada = false,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now.AddDays(1)
            },
            new Skin
            {
                SkinId = 12,
                Nome = "Faca Karambit Gamma Doppler",
                ImagemUri = "/images/karambit_gammadoppler.png",
                Preco = 7000.00,
                Desgaste = Skin.NivelDesgaste.PoucoUsada,
                DisponivelParaRetirada = true,
                DataCadastro = DateTime.Now,
                DataRetirada = DateTime.Now
            }

        };
        }

        public IList<Skin> ObterTodos()
            => _skins;

        public Skin Obter(int id) 
            => ObterTodos().SingleOrDefault(item => item.SkinId == id);

        public void Incluir(Skin skin)
        {
            var proximoId = _skins.Max(item => item.SkinId) + 1;
            skin.SkinId = proximoId;
            _skins.Add(skin);
        }

        public void Alterar(Skin skin)
        {
            var skinEncontrada = _skins.SingleOrDefault(item => item.SkinId == skin.SkinId);
            skinEncontrada.Nome = skin.Nome;
            skinEncontrada.ImagemUri = skin.ImagemUri;
            skinEncontrada.Preco = skin.Preco;
            skinEncontrada.Desgaste = skin.Desgaste;
            skinEncontrada.DisponivelParaRetirada = skin.DisponivelParaRetirada;
            skinEncontrada.DataCadastro = skin.DataCadastro;
            skinEncontrada.DataRetirada = skin.DataRetirada;
            skinEncontrada.TradeLock = skin.TradeLock;
        }

        public void Excluir(int id)
        {
            var skinEncontrada = Obter(id);
            _skins.Remove(skinEncontrada);
        }
    }
}
