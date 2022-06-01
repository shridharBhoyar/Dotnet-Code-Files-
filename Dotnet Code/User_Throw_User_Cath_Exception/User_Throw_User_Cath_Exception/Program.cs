using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Throw_User_Cath_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
 
                Console.WriteLine("Enter Your Age ");
            int ag = int.Parse(Console.ReadLine());

            if(ag>=18)
            {
                Console.WriteLine("You are Eligible");
            }
            else
            {
                throw new Exception("You are Not Eligible");
            }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Catch Blok Run");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
