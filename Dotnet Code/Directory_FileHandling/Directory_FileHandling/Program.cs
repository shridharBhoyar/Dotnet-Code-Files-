using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\ramsh";
            string path2="E:\\ramsh2";

            DirectoryInfo im = new DirectoryInfo(path);     // create Directory
            im.Create();
          //  im.CreateSubdirectory("shriii");                // create subDirectory
         //   im.MoveTo(path2);                                 // move second location
           // im.Delete(true);                                    //only empty directory delete 
            DirectoryInfo[] di = im.GetDirectories();

            foreach(var itm in di)
            {
                Console.WriteLine(itm);
            }


           
            Console.ReadLine();
        }
    }
}
