using Microsoft.AspNetCore.Mvc;

namespace MVCFactoryBurger.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
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
    }
}
