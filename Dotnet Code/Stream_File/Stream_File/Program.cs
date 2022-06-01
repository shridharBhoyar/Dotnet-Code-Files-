using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Stream_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string path="E:\\raaaamsh.txt";
            string  nam="my nam is shri";
         using (FileStream sf = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
             //   sf.WriteByte(66);  // A
                byte[] wr = Encoding.UTF8.GetBytes(nam);
                sf.Write(wr,0,nam.Length);
              //  sf.Write("");
                
            }
            Console.ReadLine();

        }
    }
}
