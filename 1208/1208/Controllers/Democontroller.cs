using Microsoft.AspNetCore.Mvc;
using _1208.Models; // 使用正確的命名空間

namespace _1208.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "陳冠廷";
            ViewBag.Dick = 22;
            return View();
        }

        public IActionResult show()
        {
            ViewData["name"] = "屁股";
            ViewBag.Dick = 22;
            return View();
        }

        public ActionResult ShowMembers()
        {
            var memberA = new Menber() { id = 1, Name = "Alex", age = 12 };
            var memberB = new Menber() { id = 2, Name = "Ben", age = 34 };
            var memberC = new Menber() { id = 3, Name = "Carol", age = 56 };
            var memberList = new List<Menber>() { memberA, memberB, memberC };
            ViewData["Members"] = memberList;
            return View();
        }

        [HttpGet]
        public string ShowHello()
        {
            return "hello";
        }

        public string ShowPrice(string product, int price)
        {
            return $"商品是{product}價格是{price}";
        }
    }
}
