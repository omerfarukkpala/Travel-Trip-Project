using MvcTravelTrip.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(8).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.BlogID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = c.Blogs.Where(x => x.BlogID == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = c.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = c.Blogs.Take(3).OrderByDescending(x => x.BlogID).ToList();
            return PartialView(values);
        }
    }
}