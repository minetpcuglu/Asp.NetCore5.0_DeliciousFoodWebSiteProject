using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Controllers
{
    [AllowAnonymous]
    public class ShowcaseController : Controller
    {
        FoodManager foodManager = new FoodManager(new EfFoodRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDetail(int id) //ürüne göre category getirme
        {
            ViewBag.Id = id;
            var value = foodManager.FoodListGetByCategory(id);
            return View(value);
        }
    }
}
