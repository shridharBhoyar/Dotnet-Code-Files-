using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    interface prson
    {
        void show();   // by deffault public  , only declaration no body

    }

    interface student
    {
        void show1();
    }

    interface addder : prson,student
    {
        void show2();

    }

    class Program :addder // inherit interface using class
    {
        public void show()
        {
            Console.WriteLine("this is show method call");
        }


        public void show1()
        {
            Console.WriteLine("this is show1 method call");
        }

        public void show2()
        {
            Console.WriteLine("this is show2 method call");
        }

        static void Main(string[] args)
        {
            addder p = new Program();
            p.show();
            p.show1();
            p.show2();
            Console.ReadLine();
        }
    }
}
