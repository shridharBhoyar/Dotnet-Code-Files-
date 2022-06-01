using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_class
{
    static class Program //static class no creat objetc of class
    {

        public static int a;
        public static int b;
        public static void show() // 
        {
            Console.WriteLine("static class");

        }
        

        static void Main(string[] args)
        {
            Program.show();  // this type initialize only
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
