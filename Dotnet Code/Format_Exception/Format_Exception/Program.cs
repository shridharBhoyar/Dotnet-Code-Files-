using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enater name");
                string a = Console.ReadLine();
                int b = int.Parse(a);             //format Exception 

                Console.WriteLine(b);
                
            }
            catch( FormatException ex)
            {
                Console.WriteLine("Format Occure.........");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
