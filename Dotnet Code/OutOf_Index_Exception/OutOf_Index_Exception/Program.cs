using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOf_Index_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] myarr = new int[3];
                myarr[0] = 11;
                myarr[1] = 22;
                myarr[2] = 33;
                myarr[3] = 44;
                foreach (int itm in myarr)
                {
                    Console.WriteLine(myarr);
                }
            }
            catch( IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index Out of range");
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
        }
    }
}
