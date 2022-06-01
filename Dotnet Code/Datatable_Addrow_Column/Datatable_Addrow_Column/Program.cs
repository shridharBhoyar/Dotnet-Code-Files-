using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datatable_Addrow_Column
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable employee = new DataTable("employee");

            DataColumn id = new DataColumn();
            id.Caption = "id";
            id.DataType = typeof(int);
            id.AllowDBNull = false;

            

            DataColumn name = new DataColumn();
            name.Caption = "name";
            name.DataType=typeof(string);
            name.AllowDBNull = false;

            DataColumn age = new DataColumn();
            name.Caption = "name";
            name.DataType = typeof(int);
            name.AllowDBNull = false;

            DataRow row1 = employee.NewRow();
            

        }
    }
}
