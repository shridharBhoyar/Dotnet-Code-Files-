using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{

    class prson
    {
        private int ag;  //access other class
        private int id;
        private string nam;

        public void show(int ag,int id,string nam) 
        {
            this.ag = ag;
            this.id = id;
            this.nam = nam;
            Console.WriteLine("age is : "+ag);
            Console.WriteLine("id is : " + id);
            Console.WriteLine("name is : " + nam);

        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            prson p = new prson();

            p.show(12,1122,"shri");  //privat variable use using public method
            Console.ReadLine();
        }
    }
}
