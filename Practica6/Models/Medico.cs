using System.ComponentModel.DataAnnotations;

namespace Practica6.Models
{
    public class Medico
    {
        [Key]
        public int MedicoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especialidad { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefono { get; set; }
        public List<Cita> Citas { get; set; }

    }
}

