using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kitaplık.Models;

namespace Kitaplık.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class KitapController : Controller
{
    public ActionResult Detay()
    {
        // Örnek bir kitap oluşturuyoruz
        var kitap = new Kitap
        {
            KitapAdi = "Örnek Kitap",
            YazarAdi = "Örnek Yazar",
            YayinlanmaTarihi = new DateTime(2020, 1, 1),
            Turu = "Örnek Tür",
            SayfaSayisi = 300,
            Fiyat = 50.00m
        };

        return View(kitap);
    }
}

