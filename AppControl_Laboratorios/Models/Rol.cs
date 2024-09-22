using System.ComponentModel.DataAnnotations;

namespace AppControl_Laboratorios.Models
{
    public class Rol
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "*Campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
