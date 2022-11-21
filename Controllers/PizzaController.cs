using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Todi Pizza";
            return View();
        }
    }
}
