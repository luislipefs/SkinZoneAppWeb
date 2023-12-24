using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;

namespace SkinZoneAppWeb.Pages
{
    public class EditModel : PageModel
    {
        public SelectList TipoOptionItems { get; set; }

        private ISkinService _service;

        public EditModel(ISkinService service)
        {
            _service = service;
        }

        [BindProperty]
        public Skin Skin { get; set; }

        public IActionResult OnGet(int id)
        {
            Skin = _service.Obter(id);

            TipoOptionItems = new SelectList(_service.ObterTodosTipos(),
                                        nameof(Tipo.TipoId),
                                        nameof(Tipo.Descricao));

            if (Skin == null)
            {
                return NotFound();
            }

            return Page();
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

            _service.Alterar(Skin);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            _service.Excluir(Skin.SkinId);

            return RedirectToPage("/Index");
        }
    }
}
