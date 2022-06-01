using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_hiding
{


    class bass
    {
         public void show()
        {
            Console.WriteLine("this is bass method");
        }
    }

    class drive : bass
    {
        public new void  show()
        {
            base.show();                               // 1st type jump base class
            Console.WriteLine("this is drive method");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            drive p = new drive();    //2rd type 
            p.show();
             //bass b = new drive(); 3rd type
            //b.show();
            
            Console.ReadLine();


        }
    }
}
