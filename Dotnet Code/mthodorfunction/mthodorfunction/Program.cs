using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mthodorfunction
{
    class Program
    {

        public void show()
        {
            Console.WriteLine("this is show function call");
        }


        static void Main(string[] args)
        {

            Program p1=new Program();
            p1.show();

            Console.ReadLine();
            

        }
    }
}
