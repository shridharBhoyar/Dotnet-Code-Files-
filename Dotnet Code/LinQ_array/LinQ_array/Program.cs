using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 11,19,22,44,55,66,77};

            var a = from i in arr where i > 20 select i;

            foreach(int  itm in a)
            {
                Console.WriteLine(itm);
            }


            string[] str = { "shri","manish ","rahul","sagar"};

            var t = from m in str where m.StartsWith("s") select m;

            foreach(string k in t)
            {
                Console.WriteLine(k);
            }

            Console.ReadLine();

        }
    }
}
