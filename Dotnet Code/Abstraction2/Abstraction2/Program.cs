using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    

    class prson
    {
         int id;
         string nam;
         public prson(int id,string nam)    // Constructor
        {
            this.id=id ;
            this.nam =nam;
        }

        public void calculate()         // abstraction method
        {
            if(this.id<=0)
            {
                Console.WriteLine("cheack id");
            }
            else
            {
                this.id += 2;
              //  Console.WriteLine(this.id);
            }
        }

        public void show()
        {

            this.calculate();                                  // abstraction method call in class
            Console.WriteLine(this.id);
            Console.WriteLine(this.nam);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            prson p = new prson(-11,"shri");
            p.show();
            Console.ReadLine();


        }
    }
}
