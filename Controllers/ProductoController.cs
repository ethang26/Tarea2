using Microsoft.AspNetCore.Mvc;
using Tarea2.Models;
using System.Collections.Generic;

namespace Tarea2.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> productos = new()
        {
            new Producto { Id = 1, Nombre = "Croquetas", Precio = 20.5m, Stock = 10 },
            new Producto { Id = 2, Nombre = "Collar", Precio = 15.0m, Stock = 5 }
        };

        public IActionResult Index()
        {
            return View(productos);
        }
    }
}
