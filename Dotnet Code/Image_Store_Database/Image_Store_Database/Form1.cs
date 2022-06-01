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
using System.IO;

namespace Image_Store_Database
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            bindgriview();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title="Selet image";
          //  ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif";
            ofd.Filter = " All Files (*.*)|*.*";
            ofd.ShowDialog();

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into STUDENT_IMAGE values(@id,@name,@age,@img)";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("id",textBox1.Text);
            cmd.Parameters.AddWithValue("name", textBox2.Text);
            cmd.Parameters.AddWithValue("age", textBox3.Text);
            cmd.Parameters.AddWithValue("img", SavePhoto());

            con.Open();

            int a=cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("inserted");
                bindgriview();
                resetcontrol();

            }
            else
            {
                MessageBox.Show("faild");
            }

            con.Close();
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        void bindgriview()
        {

            SqlConnection con = new SqlConnection(cs);
            string quarty = "select * from STUDENT_IMAGE ";
            SqlDataAdapter sda = new SqlDataAdapter(quarty, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        void resetcontrol()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pictureBox1.Image =Getbytes((byte[]) dataGridView1.SelectedRows[0].Cells[3].Value);
        }

        private Image Getbytes(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "update STUDENT_IMAGE set id = @id,name = @name, age = @age, picture = @img where id = @id";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("id", textBox1.Text);
            cmd.Parameters.AddWithValue("name", textBox2.Text);
            cmd.Parameters.AddWithValue("age", textBox3.Text);
            cmd.Parameters.AddWithValue("img", SavePhoto());

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("updeted");
                bindgriview();
                resetcontrol();

            }
            else
            {
                MessageBox.Show(" update faild");
            }

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "delete from STUDENT_IMAGE where id=@id";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("id", textBox1.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("deleted");
                bindgriview();
                resetcontrol();

            }
            else
            {
                MessageBox.Show(" deleted faild");
            }

            con.Close();
        }



    }
}
