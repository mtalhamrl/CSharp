using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Decons
{
    public class Ogrenci
    {
        /*public string AdSoyad;
        public int Numara;
        public int Sinif;

        public Ogrenci(string OgrAdSyd,int ogrNo,int ogrSinif) //constructor
        {
            AdSoyad = OgrAdSyd;
            Numara = ogrNo;
            Sinif = ogrSinif;
        }

        public void Bilgi()
        {
            Console.WriteLine("Öğrencinin adı-soyadi: " + AdSoyad);
            Console.WriteLine("Öğrenci numarası: " + Numara);
            Console.WriteLine("Öğrenci sınıfı: " + Sinif);
        }*/
        public Ogrenci() //consrtuctor
        {
            Console.WriteLine("Yapıcı metot çalıştı");
        }

        ~Ogrenci() //deconstructor
        {
            Console.WriteLine("Yıkıcı metot çalıştı");
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Numara { get; set; }
        public double Ortalama { get; set; }
    }
}
