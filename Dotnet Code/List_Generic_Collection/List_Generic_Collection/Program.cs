using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myist = new List<int>();
            myist.Add(11);
            myist.Add(22);
            myist.Add(44);
            myist.Add(55);

            Console.WriteLine("Count = "+myist.Count);
            Console.WriteLine("-----------------------------------");

            foreach(int itm in myist)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("capacity = "+myist.Capacity);
            Console.WriteLine("-----------------------------------");

            List<string> mystr = new List<string>();
            mystr.Add("shri");
            mystr.Add("manish");
            mystr.Add("rahul");
            mystr.Add("sagar");
            mystr.Add("rohit");

            foreach(string sitm in mystr)
            {
                Console.WriteLine(sitm);
            }
            Console.WriteLine("-----------------------------------");
            mystr.Insert(2,"ram");

            foreach (string siitm in mystr)
            {
                Console.WriteLine(siitm);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(mystr.Contains("shri"));
            Console.WriteLine("-----------------------------------");
            mystr.Remove("manish");

            foreach (string siitm in mystr)
            {
                Console.WriteLine(siitm);
            }
            Console.WriteLine("-----------------------------------");
            mystr.AddRange(mystr);
         //   Console.WriteLine("-----------------------------------");



            foreach (string siitm in mystr)
            {
                Console.WriteLine(siitm);
            }
            Console.WriteLine("-----------------------------------");

            employee emp1 = new employee()
            {
                id = 11,
                nam = "shri",
                age = 22


            };

            employee emp2 = new employee()
            {
                id = 12,
                nam = "manish",
                age = 33


            };

            employee emp3 = new employee()
            {
                id = 13,
                nam = "rahul",
                age = 44


            };

            List<employee> empply = new List<employee>();
            empply.Add(emp1);
            empply.Add(emp2);
            empply.Add(emp3);

            foreach(employee itm in empply)
            {
                Console.WriteLine("id is {0} name is {1} age is {2}", itm.id,itm.nam,itm.age);
            }




            Console.ReadLine();

        }
    }
}
