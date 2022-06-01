using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enapsulation2
{


    class prson
    {

        private int id;
        private string nam;

        public void setid(int id)
        {
           if(id<=0)
           {
               Console.WriteLine("pleas enter valid id");
           }
            else
           {
               this.id=id;
           }
        }

            public void  getid()
            {

                if(this.id<=0)
                {

                }
                else
                {
                    Console.WriteLine(this.id);
                }

            }


        }

    


    class Program
    {

        
        static void Main(string[] args)
        {

            prson p=new prson();
            p.setid(2);
            p.getid();
            Console.ReadLine();

        }
    }
}
