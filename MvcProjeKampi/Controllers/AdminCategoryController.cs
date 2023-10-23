using BLL.Concrete;
using BLL.ValidationRules;
using DAL.EntityFramework;
using EL.Concrate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var catValues = cm.GetCategories();
            return View(catValues);
        }

        [HttpGet]
        public ActionResult AddCategory() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValitator catVal = new CategoryValitator();
            ValidationResult result = catVal.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAddBLL(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var catValues = cm.GetByCategoryId(id);
            cm.CategoryDeleteBLL(catValues);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var catValue = cm.GetByCategoryId(id);
            return View(catValue);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdateBLL(p);
            return RedirectToAction("Index");
        }
    }
}