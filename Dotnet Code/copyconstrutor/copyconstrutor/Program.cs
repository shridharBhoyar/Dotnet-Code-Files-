using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstrutor
{

    class constru
    {
        string nam;
        int ag;
        public  constru(string nam,int ag)
        {

            this.nam = nam;
            this.ag = ag;

        }

        public void getdata()
        {

            Console.WriteLine("name is"+nam);
            Console.WriteLine("age is" + ag);
        }


        public constru(constru e)  //copy constructor
        {

            this.nam = e.nam;
            this.ag = e.ag;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            constru p = new constru("shri", 19);
            p.getdata();
            constru p1 = new constru(p);// copy constructor
            p1.getdata();
            Console.ReadLine();

        }
    }
}
