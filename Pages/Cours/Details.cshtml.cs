using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GEtudiants_Web_App.Data;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Pages.Cours
{
    public class DetailsModel : PageModel
    {
        private readonly GEtudiants_Web_App.Data.ApplicationDbContext _context;

        public DetailsModel(GEtudiants_Web_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public GEtudiants_Web_App.Models.Cours Cours { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cours == null)
            {
                return NotFound();
            }

            var cours = await _context.Cours.FirstOrDefaultAsync(m => m.Id == id);
            if (cours == null)
            {
                return NotFound();
            }
            else 
            {
                Cours = cours;
            }
            return Page();
        }
    }
}
