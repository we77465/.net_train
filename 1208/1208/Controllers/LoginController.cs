using Microsoft.AspNetCore.Mvc;
using _1208.Models; // 使用正確的命名空間
using System.Diagnostics;

namespace _1208.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public LoginController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(IFormCollection obj)
        {
            ViewBag.Account = obj["account"]; 
            ViewBag.Password = obj["password"];

            //這邊的account跟password是views傳過來的資訊
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}