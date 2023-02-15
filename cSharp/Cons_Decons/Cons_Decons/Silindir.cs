using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Decons
{
    public class Silindir
    {
        public double r;
        public double h;
        public double PI = 3.1415;

        public Silindir(double yaricap,double yukseklik)
        {
            r = yaricap;
            h = yukseklik;
        }

        public Silindir(double yaricap, double yukseklik,double piSayisi)
        {
            r = yaricap;
            h = yukseklik;
            PI = piSayisi;
        }

        public double Hacim()
        {
            return (PI * r * r * h);
        }

        public double YuzeyAlani()
        {
            return (2 * PI * r * h);
        }
    }
}
