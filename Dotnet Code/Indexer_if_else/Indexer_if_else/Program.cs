using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_if_else
{

    class prson
    {
        private int [] myarr = new int [4];

        public int this[int index]
	{
		set 
        {
            if (index >= 0 && index < myarr.Length)
            {
                if (value > 0)
                {
                    myarr[index] = value;
                }
                else
                {
                    
                    Console.WriteLine("Enter valid value  ");
                }
            }
            else
            {
                Console.WriteLine("Enter valid index  ");
            }
            
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
            p[1]=50;
            Console.WriteLine("the value is "+p[1]);
            Console.ReadLine();

        }
    }
}
