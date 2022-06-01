using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime r = DateTime.Now;     
            Console.WriteLine(r);


            Console.WriteLine("{0:d}", r);
            Console.WriteLine("{0:D}", r);
            Console.WriteLine("{0:f}", r);
            Console.WriteLine("{0:F}", r);
            Console.WriteLine("{0:g}", r); //general date
            Console.WriteLine("{0:f},{1:F}", r,r);

            Console.ReadLine();
        }
    }
}
