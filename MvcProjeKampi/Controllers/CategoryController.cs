using BLL.Concrete;
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
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetListBLL();
            return View(categoryvalues);
        }
        public ActionResult AddCategory(Category p)
        {
            cm.AddCategoryBLL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}