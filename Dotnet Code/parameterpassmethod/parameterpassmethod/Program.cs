using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterpassmethod
{
    class Program
    {


        public static void show(int a,int b)
        {
            int r =a+b;
            Console.WriteLine(r);

        }

        public static void show1(string p,int n)
        {

            Console.WriteLine("Name is "+p);
            Console.WriteLine("id is "+n);

        }


        public static void show2(string nam , int age)
        {
            Console.WriteLine("your Name is " + nam);
            Console.WriteLine(" your age is " + age);


        }


        public static void show3(string namm="aman")
        {

            Console.WriteLine("default name  "+namm);
           

        }



        public  static void show4(int q ,int v)
        {
            int z = q + v;
            Console.WriteLine(z);


        }



        static void Main(string[] args)
        {
            Program.show(50, 60);
            Program.show1("Shri",44);
            Program.show2(age: 21, nam: "Shriii");
            Program.show3();


            Console.WriteLine("Enter first val " );
           int x= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first val ");
            int y=int.Parse(Console.ReadLine());
            Program.show4(x, y);


            Console.ReadLine();
        }
    }
}
