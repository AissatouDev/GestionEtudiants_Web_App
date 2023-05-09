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
    public class IndexModel : PageModel
    {
        private readonly GEtudiants_Web_App.Data.ApplicationDbContext _context;

        public IndexModel(GEtudiants_Web_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<GEtudiants_Web_App.Models.Faculte> Faculte { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Faculte != null)
            {
                Faculte = await _context.Faculte.ToListAsync();
            }
        }
    }
}
