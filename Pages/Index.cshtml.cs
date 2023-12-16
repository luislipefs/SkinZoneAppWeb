using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;

namespace SkinZoneAppWeb.Pages;

public class IndexModel : PageModel
{

    public IList<Skin> ListaSkins { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        var service = new SkinService();

        ListaSkins = service.ObterTodos();
    }

    public void OnPost() 
    {

    }
}