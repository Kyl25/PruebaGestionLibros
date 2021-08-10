using GestionLibros.Data;
using GestionLibros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionLibros.Data;
using GestionLibros.Models;



namespace GestionLibros.Controllers
{
    public class LibrosController : Controller
    {

        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            IEnumerable<Libro> libros = _context.Libro;

            return View(libros);

        }

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LibrosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LibrosController/Create
        public ActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "EL libro se ha creado correctamente";
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpPost]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "EL libro se ha modificado correctamente";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);

        }

        [HttpPost]
        public IActionResult DeleteLibro(int? id)
        {
            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            _context.Libro.Remove(libro);
            _context.SaveChanges();

            TempData["mensaje"] = "EL libro se ha eliminado correctamente";
            return RedirectToAction("Index");



        }




    }
}
