using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Mundo_Creativo.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult PEscolar()
        {
            return View();
        }
        public IActionResult POficina()
        {
            return View();
        }
        public IActionResult PFiesta()
        {
            return View();
        }
        public IActionResult Otros()
        {
            return View();
        }
        public IActionResult Formulario()
        {
            return View();
        }
    }
}
