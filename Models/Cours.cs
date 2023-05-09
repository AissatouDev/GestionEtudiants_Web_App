namespace GEtudiants_Web_App.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Code { get; set; }
        public int VolumeHoraires { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public Niveau Niveau { get; set; }

    }
}
