using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{

    abstract class prson           //  Abstract class declare
    {

        public abstract void show();  //  method declare no body
    }



    class Program : prson             // inherit abstract class 
    {
        public override void show()  //   abstract method body
        {
            Console.WriteLine("hii abstract class");
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            p.show();
            Console.ReadLine();

        }
    }
}
