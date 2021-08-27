using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone X", Price = 6000, Description = "güzel telefon" };

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }
        public IActionResult list(int? id, string q)
        {
            var products = ProductRepository.Products;
            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {

                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            var product = new Product();

            return View(ProductRepository.GetProductById(id));
        }

        
        [HttpGet] /*Bu metod bizim create sayfamızdaki formdan gelen bilgileri alıyor ve public createye atıyor sonra aşağıdaki metod yani post adında olan  */
        public IActionResult Create()
        {           
            return View();
        }

        [HttpPost] /*Bu metodta forma yazılan bilgileri submit ettiğimizde geri göndermemizi sağlıyor. Yani kısaca bu bilgileri gönderiyor. httpget ise getiriyor.*/
        public IActionResult Create(Product p)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Description);
            Console.WriteLine(p.ImageUrl);
            Console.WriteLine(p.CategoryId);

            return View();
        }
        public IActionResult Chancing1()
        {
            return Ok();
        }
        public IActionResult Chancing2()
        {
            return Ok();
        }
        public IActionResult Cghanging3() 
        {
            return View("3");
        }
    }
}
