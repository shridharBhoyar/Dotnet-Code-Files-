using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{


    class Program
    {
        private int [] myarr = new int[4];

        public int this[int index]
        {
            get 
            {
                myarr[index]=value;
            }
            set 
            {
                return myarr[index];
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.myarr[]=5;
            Console.WriteLine("the array value is"+p.myarr[]);
            Console.ReadLine();


        }
    }
}
