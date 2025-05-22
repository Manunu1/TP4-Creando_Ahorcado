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
        Ahorcado juego = new Ahorcado();
        juego.elegirPalabra();

        ViewBag.palabra = juego.devolverPalabra();
        ViewBag.intentos = juego.devolverIntentos();
        ViewBag.letrasUsadas = juego.devolverLetrasUsadas();
        
        HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego));
        return View("Juego");
    }
    public IActionResult AdivinarLetra(char letra)
    {
        Ahorcado juego = Objeto.StringToObject<Ahorcado>(HttpContext.Session.GetString("Juego"));
        letra = Char.ToUpper(letra);
        juego.chequearLetra(letra);
        ViewBag.palabra = juego.devolverPalabra();
        ViewBag.intentos = juego.devolverIntentos();
        ViewBag.letrasUsadas = juego.devolverLetrasUsadas();
        HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego));
        return View("Juego");
    }
    public IActionResult AdivinarPalabra(string palabra)
    {
        Ahorcado juego = Objeto.StringToObject<Ahorcado>(HttpContext.Session.GetString("Juego"));

        palabra = palabra.ToUpper();
        
        ViewBag.intentos = juego.devolverIntentos();
        HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego));
        if (juego.chequearPalabra(palabra))
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