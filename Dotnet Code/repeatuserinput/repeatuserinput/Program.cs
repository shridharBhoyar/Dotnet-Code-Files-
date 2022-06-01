using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatuserinput
{
    class Program
    {
        static void Main(string[] args)
        {

            string inp;
            do
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("addition is="+(num1+num2));

                Console.WriteLine("Do you want exit");

                inp = Console.ReadLine().ToLower();
            }
            while (inp == "no");

            Console.WriteLine(" you exit");

            Console.ReadLine();
        }
    }
}
