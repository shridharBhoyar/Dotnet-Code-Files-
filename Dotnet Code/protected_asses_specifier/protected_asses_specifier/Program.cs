using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_asses_specifier
{

    class prson
    {
         protected void show()
        {
            Console.WriteLine("protected runn");
        }
    }

   
    class Program : prson       // derive class assess 
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.show();
            Console.ReadLine();
        }
    }
}
