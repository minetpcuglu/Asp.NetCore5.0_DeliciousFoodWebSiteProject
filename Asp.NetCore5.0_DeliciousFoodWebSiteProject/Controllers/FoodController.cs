using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Controllers
{
    public class FoodController : Controller
    {
        FoodManager foodManager = new FoodManager(new EfFoodRepository());
        public IActionResult Index()
        {
            var value = foodManager.GetAll();
            return View(value);
        }
    }
}
