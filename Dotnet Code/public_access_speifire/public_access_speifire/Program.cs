using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_speifire
{
 
    class prson
    {
        public void show()
        {
            Console.WriteLine("pubic assess speciufire");
        }

    }
    
    class Program
    {
      
        static void Main(string[] args)
        {
            prson p = new prson();     //other class method assess using public
            p.show();
            
            Console.ReadLine();
        }
    }
}
