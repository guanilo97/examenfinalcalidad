using Calidad20222.web.Helper;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calidad20222.web.Controllers
{
    public class IngresarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ingresar(List<Carta> carta, Palo palo)
        {
            ViewBag.Carta = Carta.Todas().ToList();
            var service = new PokerService();
            var cartas = ViewBag.Carta;
            ViewBag.Jugada = service.GetJugada(cartas);
            return View("Ingresar",cartas);
           
        }
    }
}
