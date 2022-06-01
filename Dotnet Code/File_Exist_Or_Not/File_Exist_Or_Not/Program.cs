using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Exist_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "E:\\shri.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("file is Exist");
            }
            else
            {
                Console.WriteLine("file is not Exist");
            }
            Console.ReadLine();
        }
    }
}
