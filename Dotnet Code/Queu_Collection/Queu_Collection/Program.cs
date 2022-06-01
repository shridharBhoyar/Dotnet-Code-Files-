using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queu_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myarr = new Queue();

            myarr.Enqueue(11);
            myarr.Enqueue("shri");
            myarr.Enqueue(1.1);
            myarr.Enqueue(null);
            myarr.Enqueue('A');

            foreach(object itm in myarr)
            {
                Console.WriteLine(itm);        // queue in FIFO --First in First out
            }

            Console.WriteLine("==================================");

            Console.WriteLine(" count "+myarr.Count);

            Console.WriteLine("Remove "+myarr.Dequeue());      //First remove

            Console.WriteLine("==================================");

            foreach (object itm in myarr)
            {
                Console.WriteLine(itm);       
            }


            Console.ReadLine();

        }
    }
}
