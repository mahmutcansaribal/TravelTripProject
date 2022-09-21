using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        // BİRE ÇOK İLİŞKİ OLUŞTURULDU
        /* BİR BLOGUN BİRDEN FAZLA YORUMU OLABİLİR! AMA BİR YORUM SADECE BİR BLOG İÇİN GEÇERLİ OLUR! */
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}