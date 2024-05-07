using System.ComponentModel.DataAnnotations;

namespace Practica6.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Genero { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefono { get; set; }
        public List<Cita> Citas { get; set; }


    }
}

