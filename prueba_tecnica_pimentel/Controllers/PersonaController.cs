using Microsoft.AspNetCore.Mvc;

namespace prueba_tecnica_pimentel.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

