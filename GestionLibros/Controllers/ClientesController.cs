using GestionLibros.Data;
using GestionLibros.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionLibros.Controllers
{
    public class ClientesController : Controller
    {

        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            IEnumerable<Cliente> cliente = _context.Cliente;

            return View(cliente);

        }

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Details(int id)
        {
            return View();
        }

       
        public ActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();

                TempData["mensaje"] = "EL cliente se ha creado correctamente";
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Update(cliente);
                _context.SaveChanges();

                TempData["mensaje"] = "EL cliente se ha modificado correctamente";
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

            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);

        }

        [HttpPost]
        public IActionResult DeleteCLiente(int? id)
        {
            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cliente);
            _context.SaveChanges();

            TempData["mensaje"] = "EL cliente se ha eliminado correctamente";
            return RedirectToAction("Index");
        }

    }
}
