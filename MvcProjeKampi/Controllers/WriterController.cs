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
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        // GET: Writer
        public ActionResult Index()
        {
            var wrtValues = wm.GetWriters();
            return View(wrtValues);
        }

        [HttpGet]
        public ActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriterAdd(Writer w)
        {
            WriterValidator wrtVal = new WriterValidator();
            ValidationResult result = wrtVal.Validate(w);
            if (result.IsValid)
            {
                wm.WriterAddBLL(w);
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
    }
}