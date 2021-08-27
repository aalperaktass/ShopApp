using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        // localhost:5000
        // localhost:5000/home
        // localhost:5000/home/index
        public IActionResult Index()
        {

            var productViewModel = new ProductViewModel()
            {
 
                Products = ProductRepository.Products
            };     
            return View(productViewModel);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
