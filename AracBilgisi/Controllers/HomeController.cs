using AracBilgisi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AracBilgisi.Controllers
{
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

        public ActionResult Giris(Models.User data)
        {
            var veri= new Models.User();
            veri.fiyati = 70.000;
            veri.kullanimdurumu = "iyi";
            veri.yili = 2010;
            veri.markası = "Mercedes";

            return View(veri);
            
        }
        public ActionResult Giris2(Models.User data)
        {
            var veri = new Models.User();
            veri.fiyati = 70.000;
            veri.kullanimdurumu = "iyi";
            veri.yili = 2010;
            veri.markası = "Mercedes";

            return View(veri);
        }
            
            
    }
}
