using SkinZoneAppWeb.Models;

namespace SkinZoneAppWeb.Services
{
    public interface ISkinService

    {
        IList<Skin> ObterTodos();
        Skin Obter(int id);
        void Incluir(Skin skin);
        void Alterar(Skin skin);
        void Excluir(int id);

    }
}
