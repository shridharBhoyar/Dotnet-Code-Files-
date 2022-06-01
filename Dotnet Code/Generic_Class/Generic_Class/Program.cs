using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{

    class prson <n>    //Generic class
    {
        n a;

        public void setdata(n b)  //Gereric method
        {
            this.a = b;
        }

        public void getdata()
        {

            Console.WriteLine("value is "+this.a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            prson<int> p = new prson<int>();   // create object
            p.setdata(11);
            p.getdata();
            prson<string> q = new prson <string>();
            q.setdata("shri"); 
            q.getdata();
            prson<char> x = new prson<char>();
            x.setdata('m');
            x.getdata();
            Console.ReadLine();
        }
    }
}
