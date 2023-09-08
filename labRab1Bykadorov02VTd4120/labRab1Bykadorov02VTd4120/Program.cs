using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRab1Bykadorov02VTd4120
{
    class Program
    {
        static void Main(string[] args)
        {

           // sbyte a = -8;
           // sbyte b = Math.Abs(a);
           // Console.WriteLine(b);
           // sbyte c = 10;
           // sbyte d = 16;
           // Console.WriteLine(Math.Max(c, d));
           // double e = 16;
           // Console.WriteLine(Math.Sqrt(e));
           // decimal f = 15.61M;
           // Console.WriteLine(Math.Truncate(f));

            
            int aa = 2;
            int o = 3;
            int t = 1;
            int f = 2;
            double l = aa * Math.Sin(o * t + f);
            Console.WriteLine(Math.Round(l,4));
        }
    }
}
