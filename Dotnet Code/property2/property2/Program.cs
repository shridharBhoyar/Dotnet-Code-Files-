using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property2
{

    class prson
    {

        private int ag;

        public int Proprty_nam
        {

            set
            {
                if(value<=0)
                {
                    Console.WriteLine("please enter valid data");
                }
                else
                {
                    this.ag = value;
                }
                
            }
            get
            {
                      
                    return this.ag;
                
            }

        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            prson p = new prson();
            p.Proprty_nam = 766;
            Console.WriteLine(p.Proprty_nam);
            Console.ReadLine();
        }
    }
}
