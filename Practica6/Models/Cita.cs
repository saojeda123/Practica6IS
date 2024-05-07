using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practica6.Models
{
    public class Cita
    {
        [Key]
        public int CitaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Descripcion { get; set; }

        // Relación con Paciente
        public int PacienteId { get; set; }
        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }

        // Relación con Médico
        public int MedicoId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
    }
}
