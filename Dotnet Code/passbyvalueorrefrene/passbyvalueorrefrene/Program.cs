using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyvalueorrefrene
{
    class Program
    {

        public static void passbyval(int a)
        {

            a = a + 10;
            Console.WriteLine(a);//30
        }


        public static void passbyref(ref int b)
        {

            b=b+10;
            Console.WriteLine(b); //50

        }

        static void Main(string[] args)
        {
            int a =20;
            Program.passbyval(a);
            Console.WriteLine(a);//20


            int b = 40;
            Program.passbyref(ref b); 
            Console.WriteLine(b); //50

            Console.ReadLine();
        }
    }
}
