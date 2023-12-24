using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;

namespace SkinZoneAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private ISkinService _service;
        public string DescricaoMarca {  get; set; }

        public DetailsModel(ISkinService service) 
        {
            _service = service;
        }

        public Skin Skin { get; private set; }
        public IActionResult OnGet(int id)
        {
            Skin = _service.Obter(id);
            if (Skin.TipoId is not null)
            {
                DescricaoMarca = _service.ObterTipo(Skin.TipoId.Value).Descricao;
            }
            
            if (Skin == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
