using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace sqldataa_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from EMPLOYEE";

            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();

               sda.Fill(data);

            foreach(DataRow row in data.Rows)
            {
                Console.WriteLine("{0},{1},{2}",row[0],row[1],row[2]);
              
            }

            Console.ReadLine();
        }
    }
}
