namespace GEtudiants_Web_App.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Matricule { get; init; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool EstBoursier { get; set; }
        public Niveau Niveau { get; set; }

    }
}
