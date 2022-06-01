using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer4
{
    class prson
    {
        private int[] myarr = new int[4];  // array declaration

        public int this[int index]   // indexer syntax
        {
            set 
            {
                myarr[index] = value;
            }
            get 
            {
                return myarr[index];
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            prson p = new prson();
            p[1] = 5;                                        //use object
            Console.WriteLine("the value is "+p[1] );
            Console.ReadLine();
        }
    }
}
