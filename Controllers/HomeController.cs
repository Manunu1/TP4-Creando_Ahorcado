using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4_Creando_Ahorcado.Models;

namespace TP4_Creando_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.palabra = Ahorcado.devolverPalabra();
        ViewBag.intentos = Ahorcado.devolverIntentos();
        ViewBag.letrasUsadas = Ahorcado.devolverLetrasUsadas();
        return View();
    }
    public IActionResult AdivinarLetra(char letra)
    {
        Ahorcado.chequearLetra(letra);
        ViewBag.palabra = Ahorcado.devolverPalabra();
        ViewBag.intentos = Ahorcado.devolverIntentos();
        ViewBag.letrasUsadas = Ahorcado.devolverLetrasUsadas();
        return View("Index");
    }
    public IActionResult AdivinarPalabra(string palabra)
    {
        ViewBag.intentos = Ahorcado.devolverIntentos();
        if (Ahorcado.chequearPalabra(palabra))
        {
            return View("Ganaste");
        }
        return View("Perdiste");
    }
    public IActionResult usuarioGana()
    {
        return View("Ganaste");
    }
        public IActionResult usuarioPierde()
    {
        return View("Perdiste");
    }
}