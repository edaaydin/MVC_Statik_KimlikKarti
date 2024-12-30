using Microsoft.AspNetCore.Mvc;

namespace Statik_KimlikKarti.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
