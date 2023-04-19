using Microsoft.AspNetCore.Mvc;

namespace MatheusinAppWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
    }
}
