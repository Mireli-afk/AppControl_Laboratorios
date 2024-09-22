using System.ComponentModel.DataAnnotations;

namespace AppControl_Laboratorios.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "*Campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "*Campo Apellido es obligatorio")]
        public string Apellidos { get; set; }
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "*Campo Correo es obligatorio")]
        public string Correo { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "*Campo Contraseña es obligatorio")]
        public string Contrasena { get; set; }
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public ICollection<UsuarioCurso> UsuarioCursos { get; set; }
    }
}
