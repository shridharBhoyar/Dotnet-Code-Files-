using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constru
{
    class Program
    {

        public Program()
        {
            Console.WriteLine("this is constructor");
        }


        public Program(string m , string n)
        {

            Console.WriteLine("this is name constructor");
        }

        

        public Program (int a, int b)
        {

            Console.WriteLine("this is ab constructor");
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            Program q = new Program(20,40);
            Program r = new Program("shri","jay");
          

            Console.ReadLine();

        }
    }
}
