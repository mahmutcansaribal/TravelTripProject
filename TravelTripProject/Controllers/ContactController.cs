using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
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
        public ActionResult Index(iletisim iletisim)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            c.iletisims.Add(iletisim);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}