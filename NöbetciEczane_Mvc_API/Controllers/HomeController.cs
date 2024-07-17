using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NöbetciEczane_Mvc_API.Models;
using System.Diagnostics;
using System.Net;

namespace NöbetciEczane_Mvc_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Izmir()
        {

            string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/ibb/nobetcieczaneler");
            List<IzmirModel> eczane = JsonConvert.DeserializeObject<List<IzmirModel>>(json);
            return View(eczane);
        }

        public IActionResult Kayseri()
        {

            string json = new WebClient().DownloadString("https://acikveri.kayseri.bel.tr/api/kbb/eczane");
            List<KayseriModel> eczane = JsonConvert.DeserializeObject<List<KayseriModel>>(json);

            return View(eczane);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
