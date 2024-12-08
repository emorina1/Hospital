namespace WebApplication.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Lista e Pacientave

        public string Departamenti { get; set; }

        public DateTime Termini { get; set; }

        public string CoverImage { get; set; }
    }
}