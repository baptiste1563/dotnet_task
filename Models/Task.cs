namespace dotnet_tack.Models
{
    public enum Avancement
    {
        EnCours,
        Termine,
        EnAttente
    }

    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public Avancement Status { get; set; }
        public DateTime date_rendu { get; set; }
        public DateTime dernniere_maj { get; set; }




    }

}
