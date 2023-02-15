using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Decons
{
    public class orn1
    {
        public static double x = 5.5;

        public void xDegistir(int y)
        {
            x = y;
        }

        public static double Toplam(double x,double y)
        {
            return x + y;
        }
        
       /* public int Toplamlar(int x,int y,int m)
        {
            int sonuc = 0;
            for (int i = 0; i < m; i++)
                sonuc += Toplam(x, y);
            return sonuc;
        }*/
    }
}
