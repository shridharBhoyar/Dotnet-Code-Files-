using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_inheritance_same_method
{

    interface prson
    {
        void show();
    }

    interface teacher
    {
        void show();
    }

    interface student
    {
        void show();
    }

    class inhrit : prson,teacher,student                  //same method all interface
    {
        void prson.show() 
        {
            Console.WriteLine("This is prson method");   

        }

        void teacher.show()
        {
            Console.WriteLine("This is teacher method");
        }

        void student.show()
        {
            Console.WriteLine("This is studnt method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            inhrit i = new inhrit();
            ((prson)i).show();           //call using interface and object
            ((teacher)i).show();
            ((student)i).show();

            Console.ReadLine();

        }
    }
}
