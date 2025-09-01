using System.ComponentModel.DataAnnotations;

namespace RegistroGimnasio.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Debe ser un número de teléfono válido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La identificación es obligatoria")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El período es obligatorio")]
        [Range(1, 36, ErrorMessage = "El período debe estar entre 1 y 36 meses")]
        public int PeriodoMeses { get; set; }
    }
}
