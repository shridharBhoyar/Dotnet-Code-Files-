using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimentionusingforeachloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] myarray = new int[3, 4]
            {
                {11 ,12 ,13 ,14},
                {21 ,22 ,23 ,24},
                {31 ,32 ,33 ,34}

            };

            foreach(int item in myarray)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
