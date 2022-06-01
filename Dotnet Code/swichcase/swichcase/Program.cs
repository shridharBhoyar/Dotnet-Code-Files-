using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swichcase
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            Console.WriteLine("preess a any value");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {

                case 1: Console.WriteLine("u choosee 1");
                    break;
                case 2: Console.WriteLine("u choosee 2");
                    break;
                case 3: Console.WriteLine("u choosee 3");
                    break;
                case 4: Console.WriteLine("u choosee 4");
                    break;
                default: Console.WriteLine("above  choosee  of 4");
                    break;
            }

            */


                        Console.WriteLine("preess a any value");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {

                case 1: Console.WriteLine("u choosee 1");
                    break;
                case 2: Console.WriteLine("u choosee 2");
                        Console.WriteLine(" choose color ");
                        string b = Console.ReadLine();
                          switch (b)
                            {
                              case "red" : Console.WriteLine("u choosee red");
                                 break ;
                               case "whilet" : Console.WriteLine("u choosee whited");
                                 break;
                               case  "pink":  Console.WriteLine("u choosee pink");
                                 break;
                               default:  Console.WriteLine("not available");
                                 break;
                        
                        
                          }
                    break;
                case 3: Console.WriteLine("u choosee 3");
                    break;
                case 4: Console.WriteLine("u choosee 4");
                    break;
                default: Console.WriteLine("above  choosee  of 4");
                    break;
            }


            Console.ReadLine();









        }
    }
}
