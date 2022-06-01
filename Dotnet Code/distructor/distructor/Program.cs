using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distructor
{

    class prson
    {
        public int a;
        public int b;

        public prson(int a,int b)
        {
            this.a=a;
            this.b=b;

        }

        public int getdata()
        {
            return a;
            return b;
        }

        ~ prson()
        {
            Console.WriteLine("distroctor call");
            
        }
    }


    class Program
    {

        

        static void Main(string[] args)
        {

            prson p = new prson(40,50);
           
            Console.WriteLine(p.a);
            Console.WriteLine(p.b);
          //  Console.ReadLine(); // ctrl+f5

        }
    }
}
