using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Models
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "No ha digitado ningun Nombre para el cliente.")]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "No ha digitado ningun Apellido para el cliente.")]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
    }
}
