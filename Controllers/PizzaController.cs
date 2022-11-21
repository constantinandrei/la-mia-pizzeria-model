using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzaDbContext db = new PizzaDbContext();
            List<Pizza> Pizze = db.Pizzas.ToList();
            ViewData["Title"] = "Todi Pizza";
            return View(Pizze);
        }
    }
}
