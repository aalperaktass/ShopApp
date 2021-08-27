using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data.shopapp.webui.Data;
using ShopApp.WebUI.Models;
using System.Collections.Generic;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}