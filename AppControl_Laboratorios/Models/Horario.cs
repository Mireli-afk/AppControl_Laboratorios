using System.ComponentModel.DataAnnotations;

namespace AppControl_Laboratorios.Models
{
    public class Horario
    {
        public int Id { get; set; }
        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "Campo Fecha es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        [Display(Name = "Hora de Inicio:")]
        [Required(ErrorMessage = "Campo Hora de inicio es obligatorio")]
        public string HoraIni { get; set; }
        [Display(Name = "Hora de salida:")]
        [Required(ErrorMessage = "Campo Hora de salida es obligatorio")]
        public string HoraFin { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int LaboratorioId { get; set; }
        public virtual Laboratorio Laboratorio { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
