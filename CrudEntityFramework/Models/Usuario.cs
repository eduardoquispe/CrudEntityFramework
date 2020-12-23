using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El celular es requerido.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El email es requerido.")]
        public string Email { get; set; }
    }
}
