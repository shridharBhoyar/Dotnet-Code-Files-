using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateconstructor
{
    class Program
    {
        public int a;
        public int b;
         class prson
        {
             static prson() //no parameter , only one time call ,first static call
            {
            Console.WriteLine("this is stati construtor");
            }

              public  prson()
            {

                Console.WriteLine("this is Default  construtor");
           }


            
         }

        static void Main(string[] args)
        {
            prson p = new prson();
            prson p1 = new prson();
            Console.ReadLine();
        }
    }
}
