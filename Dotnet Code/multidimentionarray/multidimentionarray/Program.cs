using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimentionarray
{
    class Program
    {
        static void Main(string[] args)
        {

           /*
             int[,] myarray = new int[3, 4]
            {

                {11,12,13,14},
                {21,22,23,24},
                {31,32,33,34}

            };

            Console.WriteLine(myarray[2, 3]);
            Console.ReadLine();

            */


            int[,] myaray = new int[3, 4]
            {

                {11,12,13,14},
                {21,22,23,24},
                {31,32,33,34}

            };

            for(int i=0; i < myaray.GetLength(0); i++)
            {
                for (int j = 0; j < myaray.GetLength(1);j++)
                {
                    Console.Write(myaray[i, j]+" ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
