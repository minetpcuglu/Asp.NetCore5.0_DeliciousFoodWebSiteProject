using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Controllers
{
    public class FoodController : Controller
    {
        Context _context = new Context();
        FoodManager foodManager = new FoodManager(new EfFoodRepository());
       

        public IActionResult Index()
        {
            var value = foodManager.GetListWithCategory(); ;
            return View(value);

        }

        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> categoryList = (from x in _context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.category = categoryList;

            return View();
        }

        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            foodManager.Add(food);
            return RedirectToAction("Index");
        }
    }
}
