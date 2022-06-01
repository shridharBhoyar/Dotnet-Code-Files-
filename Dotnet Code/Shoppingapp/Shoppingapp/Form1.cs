using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Shoppingapp
{
    public partial class Form1 : Form
    {
        int sr_no = 0;
        int tax = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {

            InitializeComponent();
            getinvoice_no();
            user_textBox4.Text = login.user;

            itemselect();

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Sr_No";
            dataGridView1.Columns[1].Name = "Item Name";
            dataGridView1.Columns[2].Name = "Unit Price";
            dataGridView1.Columns[3].Name = "Discount per Item";
            dataGridView1.Columns[4].Name = "Quantity";
            dataGridView1.Columns[5].Name = "Sub Total";
            dataGridView1.Columns[6].Name = "Tax";
            dataGridView1.Columns[7].Name = "Total Cost";



        }



        void bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from itemsdb";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        void itemselect()
        {
            select_item_comboBox1.Items.Clear();

            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from itemsdb";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string itm = dr.GetString(1);
                select_item_comboBox1.Items.Add(itm);
            }



            con.Close();

        }


        void getprice()
        {
            if (select_item_comboBox1.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection Con = new SqlConnection(cs);
                string quary = "select item_price from itemsdb where item_name=@name";
                SqlDataAdapter sda = new SqlDataAdapter(quary, Con);
                sda.SelectCommand.Parameters.AddWithValue("name", select_item_comboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {

                    price = Convert.ToInt32(data.Rows[0]["item_price"]);

                }

                unit_price_textBox9.Text = price.ToString();
            }
        }



        void discount_itm()
        {
            if (select_item_comboBox1.SelectedItem == null)
            {

            }
            else
            {
                int dis = 0;
                SqlConnection con = new SqlConnection(cs);
                string quary = "select item_discount from itemsdb where item_name=@name";
                SqlDataAdapter sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.Parameters.AddWithValue("name", select_item_comboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    dis = Convert.ToInt32(data.Rows[0]["item_discount"]);
                }
                disount_textBox11.Text = dis.ToString();
            }
        }






        private void select_item_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
            discount_itm();
            quantitytextBox2.Enabled = true;
        }

        private void quantitytextBox2_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(quantitytextBox2.Text) == true)
            {

            }
            else
            {


                int price = Convert.ToInt32(unit_price_textBox9.Text);
                int discount = Convert.ToInt32(disount_textBox11.Text);

                int quantity = Convert.ToInt32(quantitytextBox2.Text);

                int sub_total = price * quantity;
                sub_total = sub_total - discount * quantity;



                subtotaltextBox5.Text = sub_total.ToString();
            }


        }

        private void subtotaltextBox5_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(quantitytextBox2.Text) == true)
            {

            }
            else
            {
                int subtotal = Convert.ToInt32(subtotaltextBox5.Text);

                if (subtotal >= 10000)
                {
                    tax = (int)(subtotal * 0.15);
                    tax_textBox7.Text = tax.ToString();
                }
                else if (subtotal >= 6000)
                {
                    tax = (int)(subtotal * 0.10);
                    tax_textBox7.Text = tax.ToString();
                }
                else if (subtotal >= 3000)
                {
                    tax = (int)(subtotal * 0.07);
                    tax_textBox7.Text = tax.ToString();
                }
                else if (subtotal >= 1000)
                {
                    tax = (int)(subtotal * 0.05);
                    tax_textBox7.Text = tax.ToString();
                }
                else
                {
                    tax = (int)(subtotal * 0.03);
                    tax_textBox7.Text = tax.ToString();
                }
            }
        }

        private void tax_textBox7_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(quantitytextBox2.Text) == true)
            {

            }
            else
            {
                int sub_total = Convert.ToInt32(subtotaltextBox5.Text);
                int tax = Convert.ToInt32(tax_textBox7.Text);
                int total_cost = sub_total + tax;

                total_cost_textBox10.Text = total_cost.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(select_item_comboBox1.SelectedItem!=null)
            {
                getdatagridview((++sr_no).ToString(), select_item_comboBox1.SelectedItem.ToString(), unit_price_textBox9.Text, disount_textBox11.Text, quantitytextBox2.Text, subtotaltextBox5.Text, tax_textBox7.Text, total_cost_textBox10.Text);
                reset();
                final_total_cost();
                getinvoice_no();
            }
            else
            {
                MessageBox.Show("please selet item");
            }
          
        }


        void getdatagridview(string sr_no, string item_name, string unit_price, string disount, string quantity, string sub_total, string tax, string total_cost)
        {

            string[] row = { sr_no, item_name, unit_price, disount, quantity, sub_total, tax, total_cost };

            dataGridView1.Rows.Add(row);

        }


        void reset()
        {
            // invoice_textBox1.Clear();
            //user_textBox4.Clear();
            select_item_comboBox1.SelectedItem = null;
            unit_price_textBox9.Clear();
            disount_textBox11.Clear();
            quantitytextBox2.Clear();
            subtotaltextBox5.Clear();
            tax_textBox7.Clear();
            total_cost_textBox10.Clear();
            final_cost_textBox12.Clear();
            Amoun_paid_ttextBox3.Clear();
            change_textBox6.Clear();
            quantitytextBox2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        void final_total_cost()
        {
            int final_cost = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                final_cost = final_cost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            final_cost_textBox12.Text = final_cost.ToString();

        }

        private void Amoun_paid_ttextBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Amoun_paid_ttextBox3.Text) == true)
            {

            }
            else
            {
                int amoun_paid = Convert.ToInt32(Amoun_paid_ttextBox3.Text);
                int final_cost = Convert.ToInt32(final_cost_textBox12.Text);
                int chang = amoun_paid - final_cost;
                change_textBox6.Text = chang.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sr_no = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void insertbtn()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into oder_master1 values(@inv_id,@user,@datetime,@finalcost)";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("inv_id", invoice_textBox1.Text);
            cmd.Parameters.AddWithValue("user", user_textBox4.Text);
            cmd.Parameters.AddWithValue("datetime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("finalcost", final_cost_textBox12.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("inserted successful");
                getinvoice_no();
                reset();

            }
            else
            {
                MessageBox.Show("inserted faild");
            }
            con.Close();
            oder_detals_data();



        }



        int getlastInvoicNo()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select max(invoice_no) from oder_master1";
            SqlCommand cmd = new SqlCommand(quary, con);

            con.Open();

            int lastInvoiceNo=Convert.ToInt32( cmd.ExecuteScalar());

            con.Close();
            return lastInvoiceNo;
        }



           void oder_detals_data()
        {

            int a = 0;
               SqlConnection con = new SqlConnection(cs);
               try
               {


                   for (int i = 0; i < dataGridView1.Rows.Count; i++)
                   {
                       string quary = "insert into oder_details values(@inv_id,@name,@price,@discount,@quantity,@subtotal,@tax,@totalcost)";
                       SqlCommand cmd = new SqlCommand(quary, con);
                       cmd.Parameters.AddWithValue("inv_id", getlastInvoicNo());
                       cmd.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                       cmd.Parameters.AddWithValue("@price", dataGridView1.Rows[i].Cells[2].Value);
                       cmd.Parameters.AddWithValue("@discount", dataGridView1.Rows[i].Cells[3].Value);
                       cmd.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[4].Value);
                       cmd.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells[5].Value);
                       cmd.Parameters.AddWithValue("@tax", dataGridView1.Rows[i].Cells[6].Value);
                       cmd.Parameters.AddWithValue("@totalcost", dataGridView1.Rows[i].Cells[7].Value);

                       con.Open();

                       a = a + cmd.ExecuteNonQuery();

                       con.Close();

                   }
               }
               catch
               {


               }
            if(a>0)
            {
                MessageBox.Show("data added in details table");
            }
               else
            {
                MessageBox.Show("data add faild in details table");
            }
       
        }




        void getinvoice_no()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select invoice_no from oder_master1";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count < 1)
            {
                invoice_textBox1.Text = "1";
            }
            else
            {
                string quary2 = "select max(invoice_no) from oder_master1";
                SqlCommand cmd = new SqlCommand(quary2, con);
                con.Open();

                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                invoice_textBox1.Text = a.ToString();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insertbtn();
        }

        private void quantitytextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void Amoun_paid_ttextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Invoice No :" + invoice_textBox1.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 100));
            e.Graphics.DrawString("User Name :" + user_textBox4.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 150));
            e.Graphics.DrawString("Date :" + DateTime.Now.ToLongDateString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 200));
            e.Graphics.DrawString("Time :" + DateTime.Now.ToLongTimeString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 250));
            e.Graphics.DrawString("======================================================", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 300));


            e.Graphics.DrawString("ITEMS :", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 350));
            e.Graphics.DrawString("QUANTITY :", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(200, 350));
            e.Graphics.DrawString("UNIT PRICE :", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(400, 350));
            e.Graphics.DrawString("DISCOUNT :", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(600, 350));

            e.Graphics.DrawString("======================================================", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 400));

            //e.Graphics.DrawString("" + select_item_comboBox1.SelectedItem, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 450));
            //e.Graphics.DrawString("" + quantitytextBox2.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(200, 450));
            //e.Graphics.DrawString("" + unit_price_textBox9.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(400, 450));
            //e.Graphics.DrawString("" + disount_textBox11.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(600, 450));

            int gap = 450;
            //itm nam
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, gap));
                        gap = gap + 50;
                    }
                    catch
                    {

                    }
                }
            }

            //unit price
            int gap1 = 450;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(200, gap1));
                        gap1 = gap1 + 50;
                    }
                    catch
                    {

                    }
                }
            }

            //quantity
            int gap2 = 450;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(400, gap2));
                        gap2 = gap2 + 50;
                    }
                    catch
                    {

                    }
                }
            }



            //discount  int gap2 = 450;
            int gap3 = 450;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(600, gap3));
                        gap3 = gap3 + 50;
                    }
                    catch
                    {

                    }
                }
            }


            // subtotal
            e.Graphics.DrawString("======================================================", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 700));

            int subtotalprint = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                subtotalprint = subtotalprint + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);


            }

            e.Graphics.DrawString("SubTotal :" + subtotalprint.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 750));


            //taxprint
            int taxprint = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                taxprint = taxprint + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);


            }

            e.Graphics.DrawString("Total tax :" + taxprint.ToString(), new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 800));


            e.Graphics.DrawString("Final Amount :" + final_cost_textBox12.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 850));

            e.Graphics.DrawString("======================================================", new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 900));

            e.Graphics.DrawString("AmountPaid :" + Amoun_paid_ttextBox3.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("Final Amount :" + change_textBox6.Text, new Font("Areal", 16, FontStyle.Bold), Brushes.Black, new Point(40, 1000));



        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additem ai = new additem();
            ai.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            itemselect();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edititem ed = new edititem();
            ed.ShowDialog();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewdata vd = new viewdata();
            vd.ShowDialog();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailsAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            details_AndSearch ds = new details_AndSearch();
            ds.ShowDialog();
        }




    }


}