using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticnonstaticmethod
{
    class Program
    {



        public static void show()
        {

            Console.WriteLine("this is static method");
        }


        public void show1()
        {

            Console.WriteLine("this is non - static method");

        }

        static void Main(string[] args)
        {
            Program.show();

            Program p1 = new Program();
            p1.show1();

            Console.ReadLine();
        }
    }
}
