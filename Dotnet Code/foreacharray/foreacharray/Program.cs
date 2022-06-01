using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreacharray
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] myarray = new int [4];

            myarray[0] = 11;
            myarray[1] = 12;
            myarray[2] = 14;
            myarray[3] = 15;

            foreach(int item in myarray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
