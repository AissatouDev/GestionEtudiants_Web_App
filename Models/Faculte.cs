namespace GEtudiants_Web_App.Models
{
    public class Faculte
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public ICollection<Niveau> Niveaux { get; set; }

    }
}
