using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Delegat
{
    class Program
    {
        public delegate void oprationn(string a, string b);   // single delegate 

        public static void addname(string a,string b)
        {

            Console.WriteLine("your nam is "+ a +" "+ b);
        }


       

        static void Main(string[] args)
        {
           oprationn p = new oprationn(Program.addname);
           p.Invoke("shri", "bhoyar");
          // p("shri", "bhoyar");
           Console.ReadLine();

        }
    }
}
