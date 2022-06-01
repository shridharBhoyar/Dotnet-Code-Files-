using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valynamickeyword
{
    class Program
    {
        static void Main(string[] args)
        {


            var a = 20;
            var b = "shri";
            Console.WriteLine(a); 
            Console.WriteLine(b);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            //----------------------dynamic---------------- 

            dynamic n = 20;
            n = "shri";

            Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
