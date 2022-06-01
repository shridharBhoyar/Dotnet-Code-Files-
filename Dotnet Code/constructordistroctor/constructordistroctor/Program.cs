using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructordistroctor
{
    class student
    {

        public student()
        {
            Console.WriteLine("This is constructor call");
        }


        static void Main(string[] args)
        {
            student p = new student();

            Console.ReadLine();
        }
    }
}
