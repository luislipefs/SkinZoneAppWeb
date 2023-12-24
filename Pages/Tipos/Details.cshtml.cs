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
    public class DetailsModel : PageModel
    {
        private readonly SkinZoneDbContext _context;

        public DetailsModel(SkinZoneDbContext context)
        {
            _context = context;
        }

      public Tipo Tipo { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tipo == null)
            {
                return NotFound();
            }

            var tipo = await _context.Tipo.FirstOrDefaultAsync(m => m.TipoId == id);
            if (tipo == null)
            {
                return NotFound();
            }
            else 
            {
                Tipo = tipo;
            }
            return Page();
        }
    }
}
