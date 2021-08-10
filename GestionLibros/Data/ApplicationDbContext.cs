using GestionLibros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Libro> Libro { get; set; }
        public DbSet<EjemplarLibro> EjemplarLibros { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<VentaLibro> VentaLibro { get; set; }

    }
}
