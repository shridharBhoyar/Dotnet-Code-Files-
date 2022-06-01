using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace sqlcommandd
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from EMPLOYEE";
            SqlCommand cmd = new SqlCommand(quary,con);

            con.Open();

            SqlDataReader dr=cmd.ExecuteReader();
           
           // foreach(var itm in dr)
           // {
            //    Console.WriteLine("{0},{1},{2}",dr[0],dr[1],dr[2]);
           // }

            while (dr.Read())
            {
               // Console.WriteLine("{0},{1},{2}", dr[0], dr[1], dr[2]);
                Console.WriteLine("id "+ dr["Id"] +" name " +dr["name"]);
            }

            con.Close();
            Console.ReadLine();
        }
    }
}
