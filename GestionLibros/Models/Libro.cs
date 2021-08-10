using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "No ha digitado ningun titulo para el libro.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Titulo de libro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "No ha digitado ningun descripcion para el libro.")]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Descripcion de libro")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        public string Autor { get; set; }

        public int precio { get; set; }

        public List<EjemplarLibro> Ejemplares { get; set; }

       
    }
}
