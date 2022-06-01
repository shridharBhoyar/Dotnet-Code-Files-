using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance
{

    class basee
    {
        public void show1()
        {

            Console.WriteLine("this is metho of base 1 class");
        }
    }

    class drive1 : basee
    {
        public void show2()
        {

            Console.WriteLine("this is metho of 2 class");
        }

    }

    class drive2 : drive1
    {
        public void show3()
        {
            Console.WriteLine("this is method of 3 class");

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            drive2 p = new drive2();
            p.show1();
            p.show2();
            p.show3();

            Console.ReadLine();
        }
    }
}
