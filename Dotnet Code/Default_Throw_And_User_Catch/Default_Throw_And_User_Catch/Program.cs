using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Throw_And_User_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nam = null;     // Default Throw  Exception

                Console.WriteLine(nam.Length);    
            }
            catch(NullReferenceException ex)         //User Catch Exception
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
