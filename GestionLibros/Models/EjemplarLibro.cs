using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Models
{
    public class EjemplarLibro
    {
        [Key]
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public string Serie { get; set; }

        public bool Vendido { get; set; }
        public bool Reservado { get; set; }

        public int Numero { get; set; }


    }
}
