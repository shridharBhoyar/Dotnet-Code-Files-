using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expretion
{

    public delegate int mymethod(int a);

    class Program
    {
        static void Main(string[] args)
        {

            mymethod p = (a)=>                 // syntax of Lamda Expretion
            {
                a += 10;
               // Console.WriteLine(a);
                return a;
            };
            p.Invoke(20);
            Console.WriteLine(p.Invoke(20)); 
            Console.ReadLine();
        }
    }
}
