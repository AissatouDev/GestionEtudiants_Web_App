using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GEtudiants_Web_App.Data;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Pages.Niveau
{
    public class EditModel : PageModel
    {
        private readonly GEtudiants_Web_App.Data.ApplicationDbContext _context;

        public EditModel(GEtudiants_Web_App.Data.ApplicationDbContext context)
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

            var niveau =  await _context.Niveau.FirstOrDefaultAsync(m => m.Id == id);
            if (niveau == null)
            {
                return NotFound();
            }
            Niveau = niveau;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Niveau).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NiveauExists(Niveau.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NiveauExists(int id)
        {
          return (_context.Niveau?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
