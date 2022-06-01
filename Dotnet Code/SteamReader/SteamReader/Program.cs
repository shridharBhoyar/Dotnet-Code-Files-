using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SteamReaderer
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "E:\\Reader.txt";

            using (FileStream f = new FileStream(path,FileMode.Open,FileAccess.Read))        //open file then read
            {
               // f.WriteByte(66);
                using  (StreamReader b=new StreamReader(f,Encoding.UTF8))
                {
                    string s = b.ReadLine();
                    Console.WriteLine(s);

                    string h = "";

             //   while((s=b.ReadLine())!=null)    //all line read
               // {
                 //   Console.WriteLine(s);
               // }

                    foreach(var itm in b.ReadLine())
                    {
                        Console.WriteLine(itm);
                    }



                }

               
            }
            Console.ReadLine();

        }
    }
}
