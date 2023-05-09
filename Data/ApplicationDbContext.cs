using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GEtudiants_Web_App.Models;

namespace GEtudiants_Web_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GEtudiants_Web_App.Models.Etudiant> Etudiant { get; set; } = default!;
        public DbSet<GEtudiants_Web_App.Models.Niveau> Niveau { get; set; } = default!;
        public DbSet<GEtudiants_Web_App.Models.Faculte> Faculte { get; set; } = default!;
        public DbSet<GEtudiants_Web_App.Models.Cours> Cours { get; set; } = default!;
    }
}