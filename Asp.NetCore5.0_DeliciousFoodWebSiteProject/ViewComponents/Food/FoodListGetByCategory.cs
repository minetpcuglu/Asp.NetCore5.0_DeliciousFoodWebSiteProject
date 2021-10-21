using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.ViewComponents.Food
{
    public class FoodListGetByCategory:ViewComponent
    {
        FoodManager foodManager = new FoodManager(new EfFoodRepository());
        public IViewComponentResult Invoke(int id)
        {
            var value = foodManager.FoodListGetByCategory(id);
            return View(value);
        }
    }
}
