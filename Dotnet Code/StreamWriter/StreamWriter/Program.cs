using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWritere
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\new1.txt";

            using (FileStream m=new FileStream(path,FileMode.Append,FileAccess.Write))             //Create , And other mode
            {
               // m.WriteByte(66);
                using (StreamWriter s=new StreamWriter(m,Encoding.UTF8))        // stream Writer,read also access
                {
                    //s.WriteLine("  hiii language");

                    int[] arr = { 11,22,44,55,66};

                    foreach(int itm in arr)
                    {
                        s.WriteLine (itm);
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
