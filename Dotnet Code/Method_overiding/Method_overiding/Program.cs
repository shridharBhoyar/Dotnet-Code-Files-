using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overiding
{

    class bass
    {
        public virtual void   show()
        {

            Console.WriteLine("bass classss");
        }

    }

    class drive : bass
    {
        public override void  show()
        {
          //  base.show();
            Console.WriteLine("Drive classss");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            bass p = new drive();        //hide base class
            p.show();

            //bass b = new bass();
           // b.show();
            Console.ReadLine();
        }
    }
}
