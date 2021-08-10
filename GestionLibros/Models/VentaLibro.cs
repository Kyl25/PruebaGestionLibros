using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Models
{
    public class VentaLibro
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cliente")]
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
    
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }


        [Required(ErrorMessage = "La fecha es obligatoria.")]

        [Display(Name = "Fecha de reserva")]
        public DateTime FechaReserva { get; set; }

        public bool Compra { get; set; }

        public Libro Libro { get; set; }


    }
}
