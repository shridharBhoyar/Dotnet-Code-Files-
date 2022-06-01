using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {

            for( int i=1 ; i < 10 ; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("----------nested for--------------");


            for (int j = 1; j < 5 ; j++)
            {
                Console.WriteLine(j);
               for(int k=1;k<4;k++)
               {
                   Console.WriteLine("shri");
               }
            }

                Console.ReadLine();
        }
    }
}
