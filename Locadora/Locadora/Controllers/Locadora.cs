using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    public class Locadora : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}