using System.ComponentModel.DataAnnotations;

namespace AppControl_Laboratorios.Models
{
    public class Maquina
    {
        public int Id { get; set; }
        [Display(Name = "Número de serie:")]
        [Required(ErrorMessage = "*Campo Número de serie es obligatorio")]
        public string NumSerie { get; set; }
        public int LaboratorioId { get; set; }
        public virtual Laboratorio? Laboratorio { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
    }
}
