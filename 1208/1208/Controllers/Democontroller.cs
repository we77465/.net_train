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

         public ActionResult ShowShoppingList()
        {
            var member = new Member() { Id = 1, Name = "Alex", Age = 12 };
            
            var products = new List<Product>();
            products.Add(new Product { Number = 1, Name = "Apple", Price = 30 });
            products.Add(new Product { Number = 2, Name = "Banana", Price = 50 });
            products.Add(new Product { Number = 3, Name = "Cherry", Price = 100 });

            var memberInfo = new MemberInfoViewModel();
            memberInfo.Member = member;
            memberInfo.Products = products;

            return View(memberInfo);
        }


        public ActionResult ShowMembers()
        {
            var memberA = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var memberB = new Member() { Id = 2, Name = "Ben", Age = 34 };
            var memberC = new Member() { Id = 3, Name = "Carol", Age = 56 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            //ViewData["Members"] = memberList;
            //return View();
            return View(memberList);
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
