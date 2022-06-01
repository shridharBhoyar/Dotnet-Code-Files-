using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    class Program
    {


        public void show (int a)
        {
            Console.WriteLine("Enter input is  "+a);

        }

        public void show2 <n> (n b)                             // Generic method <n> 
        {
            Console.WriteLine("Enter input is  " + b);

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.show(4);
            p.show2("shri");
            Console.ReadLine();

        }
    }
}
