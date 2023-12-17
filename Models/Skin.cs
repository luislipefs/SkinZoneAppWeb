using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkinZoneAppWeb.Models
{
    public class Skin
    {
        public int SkinId { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo 'Nome' deve ter entre 2 e 50 caracteres.")]
        public string Nome { get; set; }
        public string NomeSlug => Nome.ToLower().Replace(" ", "-");

        [Required(ErrorMessage = "Campo 'Endereço URL da Imagem' obrigatório.")]
        [Display(Name = "Endereço URL da Imagem")]
        public string ImagemUri { get; set; }


        public enum NivelDesgaste
        {

            [Display(Name = "Nova de Fábrica")]
            NovaDeFabrica,

            [Display(Name = "Pouco Usada")]
            PoucoUsada,

            [Display(Name = "Testada em Campo")]
            TestadaEmCampo,

            [Display(Name = "Bem desgastada")]
            BemDesgastada,

            [Display(Name = "Veterana de Guerra")]
            VeteranaDeGuerra
        }

        [Display(Name = "Nível de desgaste")]
        [Required(ErrorMessage = "Campo 'Nível de desgaste' obrigatório.")]
        public NivelDesgaste Desgaste { get; set; }

        [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Campo 'Disponibilidade de retirada imediata' obrigatório.")]
        [Display(Name = "Disponibilidade de retirada imediata")]
        public bool DisponivelParaRetirada { get; set; }


        [Required(ErrorMessage = "Campo 'Data de cadastro' obrigatório.")]
        [Display(Name = "Data de cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }
        


        [Required(ErrorMessage = "Campo 'Dias de Tradelock' obrigatório.")]
        [Display(Name = "Dias de Tradelock")]
        public int TradeLock { get; set; }

        [Display(Name = "Data para retirada")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataRetirada { get; set; }

    }
}
