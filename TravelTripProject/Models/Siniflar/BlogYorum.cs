using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Models.Siniflar
{
    public class BlogYorum
    {
        //Hangi tablolardan veri çekeceksek IEnumerable kullanıyoruz
        //Belli sayıdaki değerleri bir koleksiyon formatında toplayan yapıdır!
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Yorumlar> Deger4 { get; set; }
    }
}