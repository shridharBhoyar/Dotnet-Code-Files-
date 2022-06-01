using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string nam = null;
                Console.WriteLine(nam.Length);
            }
            finally                                                // finally blok run 
            {
                Console.WriteLine("Hey............ i am run");
            }
            

            Console.ReadLine();

        }
    }
}
