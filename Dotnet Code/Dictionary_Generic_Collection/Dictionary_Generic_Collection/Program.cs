using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> mylist = new Dictionary<int, int>();
            Dictionary<string, string> mylist2 = new Dictionary<string, string>();
            Dictionary<int, string> mylist4 = new Dictionary<int, string>();

            mylist.Add(11, 22);
            mylist.Add(22,44);
            mylist.Add(55,66);

            foreach(var itm in mylist)
            {
                Console.WriteLine(itm);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine(mylist.Count());

            Console.WriteLine("--------------------------------");
            mylist.Remove(22);
            foreach (var itm in mylist)
            {
                Console.WriteLine(itm);
            }

            Console.WriteLine("---------------------");
            
            Console.WriteLine("--------------------------------");
            mylist2.Add("shri", "bhoyar");
            mylist2.Add("manju", "bhoyar");
            mylist2.Add("sanju", "bhoyar");

           

            foreach (var itm in mylist2)
            {
                Console.WriteLine(itm);
            }

            Console.WriteLine("--------------------------------");

            mylist4.Add(1, "shri");
            mylist4.Add(2, "manish");
            mylist4.Add(4, "rahul");

            foreach (var itm in mylist4)
            {
                Console.WriteLine(itm);
            }

            Console.ReadLine();
        }
    }
}
