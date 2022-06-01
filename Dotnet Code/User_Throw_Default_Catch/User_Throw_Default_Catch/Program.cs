using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Throw_Default_Catch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Age");
            int ag = int.Parse(Console.ReadLine());

            if(ag>18)
            {
                Console.WriteLine("You are Eligible");
            }
            else
            {
                throw new Exception("You Are not Eligible");        //User Thorw Exception the System
            }
        

            Console.ReadLine();
        }
    }
}
