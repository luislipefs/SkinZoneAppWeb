using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;
using System.Text.RegularExpressions;

namespace SkinZoneAppWeb.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        public SelectList TipoOptionItems { get; set; }

        private ISkinService _service;

        public CreateModel(ISkinService service) 
        {
            _service = service;
        }

        public void OnGet()
        {
            TipoOptionItems = new SelectList(_service.ObterTodosTipos(),
                                                    nameof(Tipo.TipoId),
                                                nameof(Tipo.Descricao));
        }

        [BindProperty]
        public Skin Skin { get; set; }

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
