using GestionLibros.Data;
using GestionLibros.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Controllers
{
    public class VentaLibrosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {


            IEnumerable<VentaLibro> libros = _context.VentaLibro;

            return View(libros);

        }

        public VentaLibrosController(ApplicationDbContext context)
        {
            _context = context;
        }


        public ActionResult Create()
        {
            IEnumerable<Libro> libros = _context.Libro;
            IEnumerable<Cliente> cliente = _context.Cliente;

            ViewBag.Cliente = cliente;
            ViewBag.Libros = libros;
          

            return View();
            
        }

        [HttpPost]
        public IActionResult Edit(VentaLibro venta)
        {
            if (ModelState.IsValid)
            {
                _context.VentaLibro.Update(venta);
                _context.SaveChanges();

                TempData["mensaje"] = "La venta del libro se ha modificado correctamente";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int? id)
        {
            IEnumerable<Libro> libros = _context.Libro;
            IEnumerable<Cliente> cliente = _context.Cliente;

            ViewBag.Cliente = cliente;
            ViewBag.Libros = libros;

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.VentaLibro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);

        }

        //Post
        [HttpPost]
        public IActionResult Create(VentaLibro Venta)
        {
            if (ModelState.IsValid)
            {
                _context.VentaLibro.Add(Venta);
                _context.SaveChanges();

                TempData["mensaje"] = "Se ha registrado la venta/Reserva de libro";
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
