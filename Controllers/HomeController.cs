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
        return View();
    }

    public IActionResult iniciarJuego()
    {
        ViewBag.palabra = Ahorcado.devolverPalabra();
        ViewBag.intentos = Ahorcado.devolverIntentos();
        ViewBag.letrasUsadas = Ahorcado.devolverLetrasUsadas();
        return View("Juego");
    }
    public IActionResult AdivinarLetra(char letra)
    {
        letra = Char.ToUpper(letra);
        Ahorcado.chequearLetra(letra);
        ViewBag.palabra = Ahorcado.devolverPalabra();
        ViewBag.intentos = Ahorcado.devolverIntentos();
        ViewBag.letrasUsadas = Ahorcado.devolverLetrasUsadas();
        return View("Juego");
    }
    public IActionResult AdivinarPalabra(string palabra)
    {
        palabra = palabra.ToUpper();
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