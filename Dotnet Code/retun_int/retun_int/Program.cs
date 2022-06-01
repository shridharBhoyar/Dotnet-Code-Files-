using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retun_int
{
    class Program
    {


        public static int show(int a,int b)
        {
            int f = a + b;
            return  f;

        }


   

        static void Main(string[] args)
        {

            Console.WriteLine(Program.show(2,6));
       

            Console.ReadLine();

        }
    }
}
