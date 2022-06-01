using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Stack_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push(11);
            mystack.Push("shri");
            mystack.Push(1.1);
            mystack.Push('A');
            mystack.Push(null);
            mystack.Push(11);

            foreach(object itm in mystack)
            {
                Console.WriteLine(itm);            // array View LIFO ( Last in First out)
            }
            Console.WriteLine("-------------------------------------");
 
            Console.WriteLine("count "+mystack.Count);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("peek " +mystack.Peek());                       
            Console.WriteLine("-------------------------------------");
            foreach (object itm in mystack)
            {
                Console.WriteLine(itm);            // array View LIFO ( Last in First out)
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" pop "+mystack.Pop());                        //Remove Element

            foreach (object itm in mystack)
            {
                Console.WriteLine(itm);            
            }

            Console.ReadLine();
        }
    }
}
