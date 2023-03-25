using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PC1.Models;

namespace PC1.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Pago()
        {
            ViewData["Title"] = "Formulario de Pago";

            return View();
        }

        [HttpPost]
		public IActionResult Calcular(
             Pago pago)
		{
                double totalMora = 0.0;
                double subTotal = 0.0;

                totalMora = pago.diasAtrasados* 0.005;

                subTotal = pago.montoPagar * totalMora;
        
                pago.Result = pago.montoPagar + subTotal;
           
            ViewData["Message"] = "Numero Tarjeta:"+ pago.numTarjeta + ", Moto a pagar: S/."+pago.Result;
            return View("Pago",pago);
		}


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
