using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace sqlDataAdaptr_Datast
{
    class Program
    {
        static void Main(string[] args)
        {

            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from EMPLOYEE";
            string quary1 = "select * from EMPLOYEE_D";
            SqlDataAdapter sda = new SqlDataAdapter(quary,con);
            SqlDataAdapter sda1 =new SqlDataAdapter(quary1,con);
            DataSet ds = new DataSet();
            DataSet ds1=new DataSet();
           
            sda.Fill(ds);
            sda1.Fill(ds1);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2}",row[0],row[1],row[2]);
            }

            Console.WriteLine("------------------------------------------");

            foreach (DataRow row1 in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2}", row1[0], row1[1], row1[2]);
            }

            Console.ReadLine();
        }
    }
}
