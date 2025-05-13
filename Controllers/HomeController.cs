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
        return View();
    }
    public IActionResult AdivinarLetra(char letra)
    {
        ViewBag.coinciden = Ahorcado.chequearLetra(letra);
        return View(Index);
    }
}
