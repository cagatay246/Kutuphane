using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Kitap
    { 
        public string kitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        public Kitap()
        {
            KayitTarihi = DateTime.Now; 
        }

        public Kitap(string kitapAdi,string yazarAdi, int sayfaSayisi, string yayinevi ): this()
        {
            kitapAdi = kitapAdi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            YazarAdi = yazarAdi;

        }
        public void BilgileriYazdir ()
        {
            Console.WriteLine($"Kitap adı: {kitapAdi}, Yazar adı: {YazarAdi}, Yayınevi: {Yayinevi}, Sayfa sayısı {SayfaSayisi} Kayıt Tarihi: {KayitTarihi.ToShortDateString()}");
        }




    }
}
