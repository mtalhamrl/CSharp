using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Decons
{
    public class Oyuncu
    {
        public static int OyuncuSayisi = 1;
        public string KullaniciAdi;
        public string Sifre;
        public int Skor;

        public Oyuncu()
        {
            OyuncuSayisi++;
            Console.WriteLine(OyuncuSayisi);
        }
        ~Oyuncu()
        {
            OyuncuSayisi--;
            Console.WriteLine(OyuncuSayisi);
        }
    }
}
