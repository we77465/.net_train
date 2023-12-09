using Microsoft.AspNetCore.Mvc;

namespace _1208.Controllers
{
    public class Democontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string showhello()
        {
            
            return "hello";
        }

        public string showprice(string product,int price)
        {
            return $"商品是{product}價格是{price}";
        }
    }
}
