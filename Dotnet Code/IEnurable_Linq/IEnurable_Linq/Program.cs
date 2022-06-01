using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnurable_Linq
{

    class stunt
    {
        public int id { get; set; }
        public string nam { get; set; }
        public int stand { get; set; }
    }

    class Program
    {
       
        
        static void Main(string[] args)
        {
           // Program p = new Program();
            stunt s = new stunt();
            s.id = 11;
            s.nam = "shri";
            s.stand = 15;

            stunt s2 = new stunt();
            s2.id = 11;
            s2.nam = "tushar";
            s2.stand = 15;

            stunt s3 = new stunt();
            s3.id = 11;
            s3.nam = "mayur";
            s3.stand = 15;

            List<stunt> students = new List<stunt>();
            students.Add(s);
            students.Add(s2);
            students.Add(s3);

            foreach(stunt itm in students)
            {
                Console.WriteLine("Id {0} name {1}  class {2}",itm.id,itm.nam,itm.stand);
            }

            Console.ReadLine();
        }
    }
}
