using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        CategoryValidator rules = new CategoryValidator();
      
        public IActionResult Index(int page=1)
        {
            var value = categoryManager.GetAll();
            return View(value.ToPagedList(page,5));
        }

        [HttpGet]
        public  IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            ValidationResult result = rules.Validate(category);
            if (result.IsValid)
            {
                categoryManager.Add(category);
                

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
