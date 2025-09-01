namespace RegistroGimnasio.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public required string Identificacion { get; set; }

        public int PeriodoMeses { get; set; }
    }

}
