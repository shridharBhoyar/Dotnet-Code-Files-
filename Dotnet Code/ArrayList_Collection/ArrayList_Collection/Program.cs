using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarr = new ArrayList();
            myarr.Add(11);
            myarr.Add("shri");
            myarr.Add(6.7);
            myarr.Add('A');
            myarr.Add(null); //null value
            myarr.Add(11); //Duplicate value

            foreach (object itm in myarr)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine("--------------------");

            Console.WriteLine( myarr.Count);
            Console.WriteLine("--------------------");
            Console.WriteLine(myarr.Capacity);
            Console.ReadLine();
        }
    }
}
