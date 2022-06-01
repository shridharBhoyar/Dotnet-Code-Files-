using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            object b = a;   // Boxing ImpliCit
            Console.WriteLine(b);

            object m = 100;
            int n= (int) m;
            Console.WriteLine(n);     // unboxing Explicit 

            Console.ReadLine();

        }
    }
}
