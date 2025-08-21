using Microsoft.AspNetCore.Mvc;
using Tarea2.Models;
using System.Collections.Generic;

namespace Tarea2.Controllers
{
    public class MascotaController : Controller
    {
        private static List<Mascota> mascotas = new();

        public IActionResult Index()
        {
            return View(mascotas);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Mascota mascota)
        {
            mascota.Id = mascotas.Count + 1;
            mascotas.Add(mascota);
            return RedirectToAction("Index");
        }
    }
}