using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        FoodValidator rules = new FoodValidator();
       

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

        public IActionResult DeleteFood(int id)
        {
            var value = foodManager.GetById(id);
            foodManager.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FoodUpdate(int id)
        {
            List<SelectListItem> categoryList = (from x in _context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.category = categoryList;
            var value = foodManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult FoodUpdate(Food food)
        {
            ValidationResult result = rules.Validate(food);
            
            if (result.IsValid)
            {

                foodManager.Update(food);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();
        
        }
    }
}
