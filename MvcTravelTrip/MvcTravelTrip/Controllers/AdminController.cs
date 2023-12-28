using MvcTravelTrip.Models.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                blog.BlogImage = "/Image/" + fileName + extension;
            }
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var find = c.Blogs.Find(id);
            c.Blogs.Remove(find);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogBring(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogBring", bl);
        }
        public ActionResult EditBlog(Blog blog)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                blog.BlogImage = "/Image/" + fileName + extension;
            }
            var bl = c.Blogs.Find(blog.BlogID);
            bl.Description = blog.Description;
            bl.BlogHeading = blog.BlogHeading;
            bl.BlogImage = blog.BlogImage;
            bl.BlogDate = blog.BlogDate;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }
        public ActionResult DeleteComment(int id)
        {
            var find = c.Comments.Find(id);
            c.Comments.Remove(find);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult CommentBring(int id)
        {
            var com = c.Comments.Find(id);
            return View("CommentBring", com);
        }
        public ActionResult EditComment(Comment com)
        {
            var cm = c.Comments.Find(com.CommentID);
            cm.UserName = com.UserName;
            cm.Mail = com.Mail;
            cm.CommentName = com.CommentName;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult ContactList()
        {
            var contacts = c.Contacts.ToList();
            return View(contacts);
        }
        public ActionResult About()
        {
            var abouts = c.Abouts.ToList();
            return View(abouts);
        }
        public ActionResult AboutBring(int id)
        {
            var ab = c.Abouts.Find(id);
            return View("AboutBring", ab);
        }
        public ActionResult EditAbout(About about)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                about.PhotoUrl = "/Image/" + fileName + extension;
            }
            var ab = c.Abouts.Find(about.AboutID);
            ab.PhotoUrl = about.PhotoUrl;
            ab.Description = about.Description;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}