using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;

namespace SkinZoneAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        public Skin Skin { get; private set; }
        public void OnGet(int id)
        {
            var service = new SkinService();
            Skin = service.Obter(id);
            
        }
    }
}
