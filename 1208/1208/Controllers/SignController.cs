using _1208.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _1208.Controllers
{
    public class SignController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SignController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sign(NewMember member)
        {
            if (!ModelState.IsValid)
            {
                return View(member);
            }
            else
            {
                TempData["Member"] = member;
                return RedirectToAction("Result");
            }
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