using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    class Program
    {

        public static int fun1(params int [] num )  //params Keyword
        {
            int sum = 0;
            foreach(int itm in num)
            {

                sum = sum + itm;
                //Console.WriteLine("value is "+num);
            }
            return sum;
            
        }


        public static int fun2(int a , params int[] num1)  //params Keyword and Parameter
        {
            int sum1 = 0;
            foreach (int itm in num1)
            {

                sum1 = sum1 + itm;
               
            }
            return sum1;

        }
        public static int fun4( int[] num1)  //params Keyword and  Array Parameter
        {
            int sum1 = 0;
            foreach (int itm in num1)
            {

                sum1 = sum1 + itm;

            }
            return sum1;

        }

     

        static void Main(string[] args)
        {
            
           Console.WriteLine(Program.fun1(5, 6, 8, 9));
           Console.WriteLine(Program.fun2(4,10,10, 10, 10, 10));
           int[] arr = { 2,4,6,8,7,9};
           Console.WriteLine(Program.fun4(arr));
            Console.ReadLine();

        }
    }
}
