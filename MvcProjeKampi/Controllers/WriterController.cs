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
        WriterValidator wrtVal = new WriterValidator();
        // GET: Writer
        public ActionResult Index()
        {
            var wrtValues = wm.GetWriters();
            return View(wrtValues);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer w)
        {
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

        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var wrtValue = wm.GetWriterById(id);
            return View(wrtValue);
        }

        [HttpPost]
        public ActionResult EditWriter(Writer w)
        {
            ValidationResult result = wrtVal.Validate(w);
            if (result.IsValid)
            {
                wm.WriterUpdateBLL(w);
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