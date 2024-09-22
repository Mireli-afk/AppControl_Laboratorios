using System.ComponentModel.DataAnnotations;

namespace AppControl_Laboratorios.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del curso:")]
        [Required(ErrorMessage = "*Campo Nombre del curso es obligatorio")]
        public string CursoNombre { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
        public ICollection<UsuarioCurso> UsuarioCursos { get; set; }
    }
}
