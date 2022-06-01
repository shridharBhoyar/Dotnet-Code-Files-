using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorlogical
{
    class Program
    {
        static void Main(string[] args)
        {
          
          /*  int a = 10, b = 20;

            if(a==10 && b==20)     // True - True = True othr False
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.ReadLine();
            */

            int a = 10, b = 20;

            if (a == 110 || b == 70)      //false - false = false other true
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.ReadLine();

        }

    }
}
