using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelTripProject.Models.Siniflar;
using PagedList.Mvc;
using PagedList;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        Yorumlar yorumlar = new Yorumlar();
        public ActionResult Index(int sayfa = 1)
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.OrderByDescending(x => x.ID).Take(50).ToList();
            //Blog sayısı alır
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(20).ToList();
            by.Deger4 = c.Yorumlars.OrderByDescending(x => x.ID).Take(20).ToList();
            return View(by);
        }
        //Nesne türettik.
        public ActionResult BlogDetay(int id)
        {
            // var blogBul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}