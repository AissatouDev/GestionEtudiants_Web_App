﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GEtudiants_Web_App.Data;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Pages.Faculte
{
    public class DetailsModel : PageModel
    {
        private readonly GEtudiants_Web_App.Data.ApplicationDbContext _context;

        public DetailsModel(GEtudiants_Web_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public GEtudiants_Web_App.Models.Faculte Faculte { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Faculte == null)
            {
                return NotFound();
            }

            var faculte = await _context.Faculte.FirstOrDefaultAsync(m => m.Id == id);
            if (faculte == null)
            {
                return NotFound();
            }
            else 
            {
                Faculte = faculte;
            }
            return Page();
        }
    }
}
