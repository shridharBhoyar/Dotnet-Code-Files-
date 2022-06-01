using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{

    struct student                          // it is not Inherit but use Interface
    {
        public void show()
        {
            Console.WriteLine("this is structure Class");
        }
    }
    class Program
    {

        public void show()
        {
            Console.WriteLine("this is  Class");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.show();
            student st = new student();    //by Default  Constructor already
            st.show();
            Console.ReadLine();

        }

        

        
    }
}
