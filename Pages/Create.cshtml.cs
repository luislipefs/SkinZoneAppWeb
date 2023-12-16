using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinZoneAppWeb.Models;

namespace SkinZoneAppWeb.Pages
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public Skin Skin { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!Skin.DisponivelParaRetirada)
            {
                Skin.DataRetirada = Skin.DataCadastro.AddDays(Skin.TradeLock);
            }
            if (Skin.TradeLock < 1)
            {
                Skin.TradeLock = 0;
            }

            var nome = Skin.Nome;
            var ImagemUri = Skin.ImagemUri;
            var Preco = Skin.Preco;
            var Desgaste = Skin.Desgaste;
            var DataCadastro = Skin.DataCadastro;
            var TradeLock = Skin.TradeLock;
            var DisponivelParaRetirada = Skin.DisponivelParaRetirada;

            return RedirectToPage("/Index");
        }
    }
}
