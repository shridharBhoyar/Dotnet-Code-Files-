using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oprator_Ovrloading
{

    class opration
    {
        public  int a;
        public  int b;
        public static opration operator +( opration p , opration p1)
        {
            opration t = new opration();
            t.a = p.a + p.b;
            t.b = p1.a + p1.b;
            Console.WriteLine("total is "+t.a);
            Console.WriteLine("total is " + t.b);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            opration p = new opration();
            opration p1 = new opration();
            opration p2 = new opration();
            p.a = 80;
            p.b = 40;

            p1.a = 55;
            p1.b = 55;
            p2 = p + p1;
            Console.ReadLine();



        }
    }
}
