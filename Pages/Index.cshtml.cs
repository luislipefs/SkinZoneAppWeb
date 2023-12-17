using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinZoneAppWeb.Models;
using SkinZoneAppWeb.Services;

namespace SkinZoneAppWeb.Pages;

public class IndexModel : PageModel
{


    private ISkinService _service;

    public IndexModel(ISkinService service)
    {
        _service = service;
    }

    public IList<Skin> ListaSkins { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaSkins = _service.ObterTodos();
    }

    public void OnPost() 
    {

    }
}