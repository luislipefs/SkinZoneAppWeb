using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;

namespace SkinZoneAppWeb.Pages
{
    public class CreateModel : PageModel
    {
        private ISkinService _service;

        public CreateModel(ISkinService service) 
        {
            _service = service;
        }

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

            _service.Incluir(Skin);

            return RedirectToPage("/Index");
        }
    }
}
