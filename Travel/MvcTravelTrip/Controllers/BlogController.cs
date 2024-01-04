using MvcTravelTrip.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog Controller
        Context c = new Context();
        BlogComment bc = new BlogComment();
        // GET: Blog
        public ActionResult Index()
        {
            //var values = c.Blogs.ToList();
            bc.Value1 = c.Blogs.ToList();
            //bc.Value3 = c.Blogs.Take(2).ToList();
            bc.Value3 = c.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            bc.Value4 = c.Comments.OrderByDescending(x => x.CommentID).Take(3).ToList();
            return View(bc);
        }

        public ActionResult BlogDetail(int id)
        {
            //var findBlog = c.Blogs.Where(x => x.BlogID == id).ToList();
            bc.Value1 = c.Blogs.Where(x => x.BlogID == id).ToList();
            bc.Value2 = c.Comments.Where(x => x.Blogid == id).ToList();
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult LeaveAComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveAComment(Comment com)
        {
            c.Comments.Add(com);
            c.SaveChanges();
            return PartialView();
        }
    }
}