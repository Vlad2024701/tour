using diploma.Db.Tour;
using diploma.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace diploma.Controllers
{
    public class HomeController : Controller
    {
        TourContext tourContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TourContext tourContext)
        {
            this.tourContext= tourContext;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tours = tourContext.Tours;
            ViewBag.Tours = tours;  
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
}