using Microsoft.AspNetCore.Mvc;
using MVCFactoryBurger.Models;
using System.Diagnostics;

namespace MVCFactoryBurger.Controllers
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

        public IActionResult SearchBurger()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchBurger(string burgerType)
        {
            BurgerFactory bf  = new BurgerFactory();

            BurgerFactory burgerFactory = new BurgerFactory();

            // Get the requested burger
            IBurger requestedBurger = burgerFactory.getBurger(burgerType.ToLower());

            // Pass the burger to the view
            ViewBag.RequestedBurger = requestedBurger;

            // Render the view with the requested burger
            return View();

        }
        public IActionResult burgerView()
        {

            BurgerFactory bf = new BurgerFactory();

            IBurger plainBurger = bf.getBurger("plain");
            IBurger chickenBurger = bf.getBurger("chicken");
            IBurger cheeseBurger = bf.getBurger("cheese");
            IBurger fishBurger = bf.getBurger("fish");

            ViewBag.PlainBurger = plainBurger;
            ViewBag.ChickenBurger = chickenBurger;
            ViewBag.CheeseBurger = cheeseBurger;
            ViewBag.FishBurger = fishBurger;

            return View();
        }
        public JsonResult LoadShit() 
        {
            var shit = "Yip, you've just loaded some shit";
            return Json(shit);
        }
    }
}
