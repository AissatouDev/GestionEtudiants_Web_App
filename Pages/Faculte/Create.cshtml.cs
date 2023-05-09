using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GEtudiants_Web_App.Data;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Pages.Faculte
{
    public class CreateModel : PageModel
    {
        private readonly GEtudiants_Web_App.Data.ApplicationDbContext _context;

        public CreateModel(GEtudiants_Web_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GEtudiants_Web_App.Models.Faculte Faculte { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Faculte == null || Faculte == null)
            {
                return Page();
            }

            _context.Faculte.Add(Faculte);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
