using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GEtudiants_Web_App.Data;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Pages.Niveau
{
    public class DeleteModel : PageModel
    {
        private readonly GEtudiants_Web_App.Data.ApplicationDbContext _context;

        public DeleteModel(GEtudiants_Web_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public GEtudiants_Web_App.Models.Niveau Niveau { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Niveau == null)
            {
                return NotFound();
            }

            var niveau = await _context.Niveau.FirstOrDefaultAsync(m => m.Id == id);

            if (niveau == null)
            {
                return NotFound();
            }
            else 
            {
                Niveau = niveau;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Niveau == null)
            {
                return NotFound();
            }
            var niveau = await _context.Niveau.FindAsync(id);

            if (niveau != null)
            {
                Niveau = niveau;
                _context.Niveau.Remove(Niveau);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
