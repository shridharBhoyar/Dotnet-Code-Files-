using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Copy_File_Filehandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path="E:\\shri.txt";
            string path2 = "E:\\ram.txt";
            File.Copy(path,path2,true);          //overide

            if(File.Exists(path2))
            {
                Console.WriteLine("file is Exist");
                Console.WriteLine(File.ReadAllText(path2));
            }
            else
            {
                Console.WriteLine("file is not Exist");
            }
            Console.ReadLine();

        }
    }
}
