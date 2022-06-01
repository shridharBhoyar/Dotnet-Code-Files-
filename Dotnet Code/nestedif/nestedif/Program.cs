using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedif
{
    class Program
    {
        static void Main(string[] args)
        {

           /* int per =int.Parse( Console.ReadLine());
            
            if(per>=80)
            {
                Console.WriteLine("grade A");
            }
            else if(per>=70)
            {
                Console.WriteLine("Grade B");
            }
            else if(per>=60)
            {
                Console.WriteLine("Grade C");

            }
            else
            {
                Console.WriteLine("low mark");
            }


            */
            
            Console.WriteLine("Enter uname");
            string name = Console.ReadLine();

            if(name=="shri")
            {
                Console.WriteLine("Enter password..");
                string pass = Console.ReadLine();

                if(pass == "shri124")
                {
                
                    Console.WriteLine("Log in succsfully");
                }
                else
                {
                    Console.WriteLine("password eroor");
                }
            }
            else
            {
                Console.WriteLine("uname error");
            }

            Console.ReadLine();

        }
    }
}
