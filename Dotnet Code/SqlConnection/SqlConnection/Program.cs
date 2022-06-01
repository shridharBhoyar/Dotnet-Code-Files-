using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlConnectionn
{
    class Program
    {
      
        
        static void Main(string[] args)
        {

            Program.conn();
            Console.ReadLine();

        }

        static void conn()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
         //   string quary = "select * from EMPLOYEE_D";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            if(con.State==System.Data.ConnectionState.Open)
            {
                Console.WriteLine("connection establis");
                con.Close();
            }
            else
            {
                Console.WriteLine("connection not establis");

            }




           
            
        }
    }
}
