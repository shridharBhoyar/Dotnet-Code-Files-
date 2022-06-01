using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpstatement
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i=1;i<=5;i++)
            {
                
                if(i==4)
                {
                    break;   //when conition equal then foop exit 
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------");

            for (int j = 1; j <= 5;j++)
            {

                if(j==2)
                {
                    continue;//when condition is true jump in direct for statement 
                }
                Console.WriteLine(j);
            }
            Console.WriteLine("------------------goto--------------");

            int k = 1;
            while ( k < 6 )
            {
                Console.WriteLine(k);
                if(k==4)
                {
                    goto start ;// goto statement jupm direct the lable

                }
                k++;
            }
            start: Console.WriteLine("hiii goto is jump");
                Console.ReadLine();
        }
    }
}
