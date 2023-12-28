using MvcTravelTrip.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTravelTrip.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        Context c = new Context();
        // GET: Gallery
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
    }
}