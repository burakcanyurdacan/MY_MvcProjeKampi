using BLL.Concrete;
using DAL.EntityFramework;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        // GET: Heading
        public ActionResult Index()
        {
            var hdngValues = hm.GetHeadings();
            return View(hdngValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> catList = (from x in cm.GetCategories()
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();

            List<SelectListItem> wrtList = (from x in wm.GetWriters()
                                            select new SelectListItem
                                            {
                                                Text = x.WriterName + " " + x.WriterSurname,
                                                Value = x.WriterId.ToString()
                                            }).ToList();
            ViewBag.vlc = catList;
            ViewBag.vlw = wrtList;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading h)
        {
            h.HeadingDate = DateTime.Now;
            hm.HeadingAddBLL(h);
            return RedirectToAction("Index");
        }

        public ActionResult ContentByHeading()
        {

            return View();
        }
    }
}