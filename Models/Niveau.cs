namespace GEtudiants_Web_App.Models
{
    public class Niveau
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public Faculte Faculte { get; set; }
        public ICollection<Cours> Cours { get; set; }
        public ICollection<Etudiant> Etudiants { get; set; }

    }
}
