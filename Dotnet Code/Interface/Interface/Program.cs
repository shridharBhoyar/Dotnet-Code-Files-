using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    interface student2  // syntax of interface 
    {
        void show();     // only declaration
    }

    class Program 
    {
        public void show()     // Interface method body
        {
            Console.WriteLine("this is interface class");
        }
        static void Main(string[] args)
        {
            Program t = new Program();  // calling method
            t.show();
            Console.ReadLine();

        }
    }
}
