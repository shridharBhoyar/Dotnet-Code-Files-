using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Exeption
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
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
          }
    }
}
