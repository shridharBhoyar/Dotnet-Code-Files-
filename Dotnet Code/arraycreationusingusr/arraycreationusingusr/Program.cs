using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraycreationusingusr
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter array Lenght");
            int a=int.Parse(Console.ReadLine());

            int [] myarr = new int [a] ;

            for(int i=0; i< a ;i++)
            {
                Console.WriteLine("Enter the data");
                int data = int.Parse(Console.ReadLine());

                 myarr [i] = data ;



            }

            foreach( int item in myarr)
            {
                Console.WriteLine("Your data is " +item);
               // Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
