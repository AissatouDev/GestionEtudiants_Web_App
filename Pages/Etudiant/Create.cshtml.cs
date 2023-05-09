﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GEtudiants_Web_App.Data;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Pages.Etudiant
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
        public GEtudiants_Web_App.Models.Etudiant Etudiant { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Etudiant == null || Etudiant == null)
            {
                return Page();
            }

            _context.Etudiant.Add(Etudiant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
