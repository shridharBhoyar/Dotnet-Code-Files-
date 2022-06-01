using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Multiple_Catch_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               /* int[] myarr = new int[3];
                myarr[0] = 11;
                myarr[1] = 12;
                myarr[2] = 13;
                myarr[3] = 14;                  // 1st Exception  but only 1 Catch

                foreach (int itm in myarr)
                {
                    Console.WriteLine(myarr);
                }
                */
                string nam = null;                 // 2nd Exception 
                Console.WriteLine(nam.Length);

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("index Catch");
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Null Catch");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)                      //other Exception Handle This 
            {
                Console.WriteLine("Parent Catch");
                Console.WriteLine(ex.Message);
            }

            

            Console.ReadLine();
        }
    }
}
