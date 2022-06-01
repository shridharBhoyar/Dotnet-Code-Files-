using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delecate
{

    public delegate void calculation(int a, int b);

    class Program
    {
        public static void add(int a, int b)
        {
            int x = a + b;
            Console.WriteLine("addition is " + x);
        }

        public static void sub(int a, int b)
        {
            int l = a - b;
            Console.WriteLine("substraction is " + l);
        }

        public static void mul(int a, int b)
        {
            int m = a * b;
            Console.WriteLine("multiplication is " + m);
        }




        static void Main(string[] args)
        {
            calculation p = new calculation(Program.add); // Type 1 to call
            p.Invoke(60, 77);
            Program.sub(5, 4);   // type 2 to call
            p = mul;      //type 3 to call
            mul(4, 4);

            Console.ReadLine();

        }
    }
}
