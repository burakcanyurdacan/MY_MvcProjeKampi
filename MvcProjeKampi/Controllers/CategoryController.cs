using BLL.Concrete;
using BLL.ValidationRules;
using FluentValidation.Results;
using DAL.EntityFramework;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetCategories();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.AddCategoryBLL(p);
            CategoryValitator catVal = new CategoryValitator();
            ValidationResult results = catVal.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAddBLL(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}