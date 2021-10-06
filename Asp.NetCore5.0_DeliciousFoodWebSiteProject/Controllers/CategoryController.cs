using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
      
        public IActionResult Index()
        {
            var value = categoryManager.GetAll();
            return View(value);
        }

        [HttpGet]
        public  IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            categoryManager.Add(category);
            //TempData["alertmessage"] = $"{category.CName} Added Category";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var value = categoryManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            category.CStatus = true;
            categoryManager.Update(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var value = categoryManager.GetById(id);
            value.CStatus = false;
            categoryManager.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
