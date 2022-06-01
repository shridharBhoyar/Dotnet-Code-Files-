using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Reading
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "E:\\shri.txt";
            if(File.Exists(path))
            {
                 Console.WriteLine("file is Exist");

                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                 Console.WriteLine("file is not Exist");
            }
            Console.ReadLine();
        }
    }
}
