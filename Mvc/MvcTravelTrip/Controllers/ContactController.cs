using MvcTravelTrip.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTravelTrip.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact ct)
        {
            c.Contacts.Add(ct);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}