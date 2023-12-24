using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkinZoneAppWeb.Data;
using SkinZoneAppWeb.Models;

namespace SkinZoneAppWeb.Pages.Tipos
{
    public class IndexModel : PageModel
    {
        private readonly SkinZoneDbContext _context;

        public IndexModel(SkinZoneDbContext context)
        {
            _context = context;
        }

        public IList<Tipo> Tipo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tipo != null)
            {
                Tipo = await _context.Tipo.ToListAsync();
            }
        }
    }
}
