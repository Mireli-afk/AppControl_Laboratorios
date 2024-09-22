using System.ComponentModel.DataAnnotations;

namespace AppControl_Laboratorios.Models
{
    public class Laboratorio
    {
        public int Id { get; set; }
        [Display(Name = "Nombre de laboratorio")]
        [Required(ErrorMessage = "*Campo Nombre de laboratorio es obligatorio")]
        public string LaboratorioNombre { get; set; }
        public ICollection<Horario> Horarios { get; set; }
        public ICollection<Maquina> Maquinas { get; set; }
    }
}
