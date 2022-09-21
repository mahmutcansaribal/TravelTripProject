using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        //BLOG EKLEME KISMI
        [HttpGet] //Sayfa Yüklendiğinde sayfa 
        [Authorize]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost] //Sayfaya bir şey gönderdiğimde çalışır
        [Authorize]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //BLOG SİLME KISMI
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            //Id'den gelen degerleri bulduk
            var degerler = c.Blogs.Find(id);
            c.Blogs.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //Güncelleme işlemi veri gönderme
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var degerler = c.Blogs.Find(id);
            return View("BlogGetir", degerler);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Blogs.Find(b.ID);
            blog.Aciklama = b.Aciklama;
            blog.Baslik = b.Baslik;
            blog.BlogImage = b.BlogImage;
            blog.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        // Yorum Listesi Getirme
        [Authorize]
        public ActionResult YorumListesi()
        {
            var degerler = c.Yorumlars.ToList();
            return View(degerler);
        }
        // Yorum Silme
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            //Id'den gelen degerleri bulduk
            var degerler = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        // Yorum getirme
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var degerler = c.Yorumlars.Find(id);
            return View("YorumGetir", degerler);
        }
        //Güncelleme İşlemi
        [Authorize]
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult iletisimListesi()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult IletisimSil(int id)
        {
            //Id'den gelen degerleri bulduk
            var degerler = c.iletisims.Find(id);
            c.iletisims.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("iletisimListesi");
        }
        [Authorize]
        public ActionResult iletisimGetir(int id)
        {
            var degerler = c.iletisims.Find(id);
            return View("iletisimGetir", degerler);
        }
        [Authorize]
        public ActionResult iletisimGuncelle(iletisim i)
        {
            var iletisim = c.iletisims.Find(i.ID);
            iletisim.AdSoyad = i.AdSoyad;
            iletisim.Mail = i.Mail;
            iletisim.Konu = i.Konu;
            iletisim.Mesaj = i.Mesaj;
            c.SaveChanges();
            return RedirectToAction("iletisimListesi");
        }
    }
}