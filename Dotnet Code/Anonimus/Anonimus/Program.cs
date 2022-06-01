using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimus
{

    public delegate int mymthod(int a);  // void // use delegate declaration
    class Program
    {


        static void Main(string[] args)
        {
            mymthod p = delegate(int a)   // use this syntax  (his method but no name)
            {
                a += 5;
                return a;
              //  Console.WriteLine(a);
            };
            p.Invoke(5);
            Console.WriteLine(p.Invoke(5));
            Console.ReadLine();

        }
    }
}
