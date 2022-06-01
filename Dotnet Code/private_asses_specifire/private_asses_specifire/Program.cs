using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_asses_specifire
{

   class prson
    {
        private  void show()
        {
            Console.WriteLine("private assess speciufire");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            prson p = new prson();
           // p.show();      // not assss because method is private
            Console.ReadLine();
        }
    }
}
