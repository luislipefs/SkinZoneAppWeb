namespace SkinZoneAppWeb.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Descricao { get; set;}

        public ICollection<Skin>? Skins { get; set;}

    }
}
