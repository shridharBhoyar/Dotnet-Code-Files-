using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritne
{


    class bassclass
    {
        public int a;
        public int b;
        public int v;
        public void show()
        {

            Console.WriteLine("this is metho of base class");
        }

    }

    class driveclass : bassclass
    {

        
        public int m;
        public int n;
    }


    class Program
    {
        static void Main(string[] args)
        {

            driveclass p = new driveclass();
            p.v = 40;
            p.a = 50;
            p.show();
            
            Console.WriteLine(p.v);
            Console.WriteLine(p.a);

            Console.ReadLine();
        }
    }
}
