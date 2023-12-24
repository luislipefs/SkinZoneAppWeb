using SkinZoneAppWeb.Data;
using SkinZoneAppWeb.Models;

namespace SkinZoneAppWeb.Services.Data
{
    public class SkinService : ISkinService
    {
        private SkinZoneDbContext _context;
        public SkinService(SkinZoneDbContext context) 
        {
            _context = context;
        }

        public void Alterar(Skin skin)
        {
            var skinEncontrada = Obter(skin.SkinId);
            skinEncontrada.Nome = skin.Nome;
            skinEncontrada.ImagemUri = skin.ImagemUri;
            skinEncontrada.Preco = skin.Preco;
            skinEncontrada.Desgaste = skin.Desgaste;
            skinEncontrada.DisponivelParaRetirada = skin.DisponivelParaRetirada;
            skinEncontrada.DataCadastro = skin.DataCadastro;
            skinEncontrada.DataRetirada = skin.DataRetirada;
            skinEncontrada.TradeLock = skin.TradeLock;
            skinEncontrada.TipoId = skin.TipoId;    

            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var skinEncontrada = Obter(id);
            _context.Skin.Remove(skinEncontrada);
            _context.SaveChanges();
        }

        public void Incluir(Skin skin)
        {
            _context.Skin.Add(skin);
            _context.SaveChanges();
        }

        public Skin Obter(int id)
        {
            return _context.Skin.SingleOrDefault(item => item.SkinId == id);
        }
        public Tipo ObterTipo(int id) => _context.Tipo.SingleOrDefault(item => item.TipoId == id);

        public IList<Skin> ObterTodos()
        {
            return _context.Skin.ToList();
        }

        public IList<Tipo> ObterTodosTipos() => _context.Tipo.ToList();
    }
}
