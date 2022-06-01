using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Program
    {
        public void add()                  // one method but different parameter
        {
            Console.WriteLine("Hello C#");
        }

        public void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);

        }

        public void add(string m, string n)
        {

            Console.WriteLine(m +""+n);
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            p.add();
            p.add(40,50);
            p.add("shri", "Bhoyar");
            Console.ReadLine();

        }
    }
}
