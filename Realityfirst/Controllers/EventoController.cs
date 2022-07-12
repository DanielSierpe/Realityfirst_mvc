using Microsoft.AspNetCore.Mvc;

namespace Realityfirst.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
