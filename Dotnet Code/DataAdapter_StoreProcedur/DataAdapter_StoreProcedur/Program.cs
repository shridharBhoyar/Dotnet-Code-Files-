using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAdapter_StoreProcedur
{
    class Program
    {
        static void Main(string[] args)
        {

            string cs=ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string quary = "spgetdata";
            SqlDataAdapter sda = new SqlDataAdapter(quary,con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1}.{2}",row[0],row[1],row[2]);
            }

            Console.WriteLine("=========================================");

            foreach (DataRow row in ds.Tables[1].Rows)
            {
                Console.WriteLine("{0},{1}.{2}", row[0], row[1], row[2]);
            }

            Console.ReadLine();
        }
    }
}
