using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Decons
{
    public class Yıkıcı
    {
        ~Yıkıcı()
        {
            Console.WriteLine("Yıkıcı tim geldi");
        }
    }
}
