﻿using BusinessLayer.Concrete;
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
            //categoryManager.Add(category);
            //TempData["alertmessage"] = $"{category.CName} Added Category";
         
            return RedirectToAction("Index");
        }
    }
}
