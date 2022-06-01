using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_get_property
{
    class prson
    {
        private int ag;
       // private int ib;

        public int _ag  //_ag property name
        {
          set
          {
            this.ag =value;  //note
          }

          get
          {
            return this.ag;  //private ag access other class

          }
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            prson p = new prson();
            p._ag = 56;                  //set property value
            Console.WriteLine(p._ag);
            Console.ReadLine();

        }
    }
}
