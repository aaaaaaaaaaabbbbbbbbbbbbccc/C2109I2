using DemoSessiion1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSessiion1_MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View("ABC");
        }

        public IActionResult Index3()
        {
            ViewBag.id = 123;
            ViewBag.username = "abc";
            ViewBag.price = 4.5;
            ViewBag.quantity = 2;
            ViewBag.photo = "thumb1.gif";
            ViewBag.product = new Product
            {
                Id = 1,
                Name = "Name 1",
                Photo = "thumb1.gif",
                Price = 4.5,
                Quantity = 2,
                Created = DateTime.Now
            };
            ViewBag.names = new List<string>
            {
                "Name 1", "Name 2", "Name 3", "Name 4", "Name 5"
            };
            ViewBag.products = new List<Product>
            {
                new Product
                    {
                        Id = 1,
                        Name = "Name 1",
                        Photo = "thumb1.gif",
                        Price = 4.5,
                        Quantity = 2,
                        Created = DateTime.Now
                    },
                new Product
                    {
                        Id = 2,
                        Name = "Name 2",
                        Photo = "thumb2.gif",
                        Price = 6.7,
                        Quantity = 3,
                        Created = DateTime.Now
                    },
                new Product
                    {
                        Id = 3,
                        Name = "Name 3",
                        Photo = "thumb3.gif",
                        Price = 3.4,
                        Quantity = 7,
                        Created = DateTime.Now
                    }
            };
            return View("Index3");
        }

    }
}
