using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        string nam;
        int ag;
        public Program(string nam,int ag)
        {
            this.nam = nam;    // this use current class variable asses 
            this.ag = ag;

            Console.WriteLine(nam);
            Console.WriteLine(ag);
        }

        static void Main(string[] args)
        {
            Program p = new Program("shri",18);

            Console.ReadLine();
        }
    }
}
