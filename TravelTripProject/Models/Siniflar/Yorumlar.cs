using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        //İLİŞKİ YAPACAĞIZ!
        // Sebebi ise her yorum eklediğimiz de yeni bir blog oluşmasının önüne geçmek!
        public virtual Blog Blog { get; set; }
    }
}