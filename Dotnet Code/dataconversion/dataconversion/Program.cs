using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            float b = a; //impliit conversion
            Console.WriteLine(b);


            float r = 40.66f;
            // int p = (int)r;  //miss .66 value
            int p = Convert.ToInt32(r);


            string k = "20";
            string l = "89";
            int v = Convert.ToInt32(k) +Convert.ToInt32(l);  //use this metho
         //   int v = int (k) + int (l);
         //   int v = int.Parse(k) + int.Parse(l);  // only string addtion
            //        float.parse(k) + float.parse(l);  use float value

            Console.WriteLine(v);
      







            Console.ReadLine();

           

        }
    }
}
